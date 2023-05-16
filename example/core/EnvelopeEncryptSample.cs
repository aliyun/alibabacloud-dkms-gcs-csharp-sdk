using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace AlibabaCloud.Dkms.Gcs.Sdk.Example
{
    public class EnvelopeEncryptSample
    {
        public static AlibabaCloud.Dkms.Gcs.OpenApi.Models.Config CreateKmsInstanceConfig(string clientKeyFile, string password, string endpoint, string caFilePath)
        {
            AlibabaCloud.Dkms.Gcs.OpenApi.Models.Config config = new AlibabaCloud.Dkms.Gcs.OpenApi.Models.Config();
            config.ClientKeyFile = clientKeyFile;
            config.Password = password;
            config.Endpoint = endpoint;
            config.CaFilePath = caFilePath;
            return config;
        }

        public static async Task<AlibabaCloud.Dkms.Gcs.OpenApi.Models.Config> CreateKmsInstanceConfigAsync(string clientKeyFile, string password, string endpoint, string caFilePath)
        {
            AlibabaCloud.Dkms.Gcs.OpenApi.Models.Config config = new AlibabaCloud.Dkms.Gcs.OpenApi.Models.Config();
            config.ClientKeyFile = clientKeyFile;
            config.Password = password;
            config.Endpoint = endpoint;
            config.CaFilePath = caFilePath;
            return config;
        }

        public static AlibabaCloud.Dkms.Gcs.Sdk.Client CreateClient(AlibabaCloud.Dkms.Gcs.OpenApi.Models.Config kmsInstanceConfig)
        {
            return new AlibabaCloud.Dkms.Gcs.Sdk.Client(kmsInstanceConfig);
        }

        public static async Task<AlibabaCloud.Dkms.Gcs.Sdk.Client> CreateClientAsync(AlibabaCloud.Dkms.Gcs.OpenApi.Models.Config kmsInstanceConfig)
        {
            return new AlibabaCloud.Dkms.Gcs.Sdk.Client(kmsInstanceConfig);
        }
    
        public static AlibabaCloud.Dkms.Gcs.Sdk.Models.GenerateDataKeyResponse GenerateDataKey(AlibabaCloud.Dkms.Gcs.Sdk.Client client, string keyId, int? numberOfBytes)
        {
            AlibabaCloud.Dkms.Gcs.Sdk.Models.GenerateDataKeyRequest request = new AlibabaCloud.Dkms.Gcs.Sdk.Models.GenerateDataKeyRequest
            {
                KeyId = keyId,
                NumberOfBytes = numberOfBytes,
            };
            //忽略ca证书认证
            //AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            //runtime.IgnoreSSL = true;
            //return client.GenerateDataKeyWithOptions(request,runtime);
            return client.GenerateDataKey(request);
        }

        public static async Task<AlibabaCloud.Dkms.Gcs.Sdk.Models.GenerateDataKeyResponse> GenerateDataKeyAsync(AlibabaCloud.Dkms.Gcs.Sdk.Client client, string keyId, int? numberOfBytes)
        {
            AlibabaCloud.Dkms.Gcs.Sdk.Models.GenerateDataKeyRequest request = new AlibabaCloud.Dkms.Gcs.Sdk.Models.GenerateDataKeyRequest
            {
                KeyId = keyId,
                NumberOfBytes = numberOfBytes,
            };
            //忽略ca证书认证
            //AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            //runtime.IgnoreSSL = true;
            //return await client.GenerateDataKeyWithOptionsAsync(request,runtime);
            return await client.GenerateDataKeyAsync(request);
        }

        private static readonly int GCM_TAG_LENGTH = 16;
        private static readonly int GCM_IV_LENGTH = 12;
        public static void Main(string[] args)
        {
            string regionId = "your-regionId";
            string caFilePath = "your-caFilePath";
            string endpoint = "your-endpoint";
            AlibabaCloud.Dkms.Gcs.OpenApi.Models.Config kmsInstanceConfig = CreateKmsInstanceConfig(AlibabaCloud.DarabonbaEnv.Client.GetEnv("ClientKeyFile"), AlibabaCloud.DarabonbaEnv.Client.GetEnv("Password"), endpoint, caFilePath);
            AlibabaCloud.Dkms.Gcs.Sdk.Client client = CreateClient(kmsInstanceConfig);
            //generateDataKey
            string keyId = "your-keyId";
            string numberOfBytes = "your-numberOfBytes";
            AlibabaCloud.Dkms.Gcs.Sdk.Models.GenerateDataKeyResponse generateDataKeyRes = GenerateDataKey(client, keyId, AlibabaCloud.DarabonbaNumber.NumberUtil.ParseInt(numberOfBytes));

            var iv = new byte[GCM_IV_LENGTH];
            SecureRandom random = new SecureRandom();
            random.NextBytes(iv);
            var key = generateDataKeyRes.Plaintext;
            var plaintext = Encoding.UTF8.GetBytes("your-plaintext");

            //使用明文key 本地加密数据
            var encryptedBytes = encryptData(key, plaintext, iv);

            //保存解密所需参数
            EnvelopeCipherPersistObject envelopeCipherPersistObject = new EnvelopeCipherPersistObject();
            envelopeCipherPersistObject.CipherText = encryptedBytes;
            envelopeCipherPersistObject.EncryptedDataKey = generateDataKeyRes.CiphertextBlob;
            envelopeCipherPersistObject.Iv = iv;
            envelopeCipherPersistObject.DataKeyIV = generateDataKeyRes.Iv;
        }
        private static byte[] encryptData(byte[] key, byte[] plaintext, byte[] iv)
        {
            GcmBlockCipher cipher = new GcmBlockCipher(new AesFastEngine());
            AeadParameters parameters =
                         new AeadParameters(new KeyParameter(key), GCM_TAG_LENGTH * 8, iv);

            cipher.Init(true, parameters);
            byte[] encryptedBytes = new byte[cipher.GetOutputSize(plaintext.Length)];
            Int32 retLen = cipher.ProcessBytes
                           (plaintext, 0, plaintext.Length, encryptedBytes, 0);
            cipher.DoFinal(encryptedBytes, retLen);
            return encryptedBytes;
        }
        public class EnvelopeCipherPersistObject
        {
            private byte[] dataKeyIV;
            private byte[] encryptedDataKey;
            private byte[] iv;
            private byte[] cipherText;

            public EnvelopeCipherPersistObject()
            {
            }

            public EnvelopeCipherPersistObject(byte[] dataKeyIV, byte[] encryptedDataKey, byte[] iv, byte[] cipherText)
            {
                this.DataKeyIV = dataKeyIV;
                this.EncryptedDataKey = encryptedDataKey;
                this.Iv = iv;
                this.CipherText = cipherText;
            }

            public byte[] DataKeyIV
            {
                get
                {
                    return dataKeyIV;
                }

                set
                {
                    dataKeyIV = value;
                }
            }

            public byte[] EncryptedDataKey
            {
                get
                {
                    return encryptedDataKey;
                }

                set
                {
                    encryptedDataKey = value;
                }
            }

            public byte[] Iv
            {
                get
                {
                    return iv;
                }

                set
                {
                    iv = value;
                }
            }

            public byte[] CipherText
            {
                get
                {
                    return cipherText;
                }

                set
                {
                    cipherText = value;
                }
            }
        }

    
    }
}
