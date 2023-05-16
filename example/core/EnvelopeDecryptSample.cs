using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaCloud.Dkms.Gcs.Sdk.Example
{
    internal class EnvelopeDecryptSample
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
        public static AlibabaCloud.Dkms.Gcs.Sdk.Models.DecryptResponse Decrypt(AlibabaCloud.Dkms.Gcs.Sdk.Client client, string keyId, byte[] ciphertextBlob, byte[] iv)
        {
            AlibabaCloud.Dkms.Gcs.Sdk.Models.DecryptRequest request = new AlibabaCloud.Dkms.Gcs.Sdk.Models.DecryptRequest
            {
                KeyId = keyId,
                CiphertextBlob = ciphertextBlob,
                Iv = iv,
            };
            //忽略ca证书认证
            //AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            //runtime.IgnoreSSL = true;
            //return client.DecryptWithOptions(request,runtime);
            return client.Decrypt(request);
        }

        public static async Task<AlibabaCloud.Dkms.Gcs.Sdk.Models.DecryptResponse> DecryptAsync(AlibabaCloud.Dkms.Gcs.Sdk.Client client, string keyId, byte[] ciphertextBlob,byte[] iv)
        {
            AlibabaCloud.Dkms.Gcs.Sdk.Models.DecryptRequest request = new AlibabaCloud.Dkms.Gcs.Sdk.Models.DecryptRequest
            {
                KeyId = keyId,
                CiphertextBlob = ciphertextBlob,
                Iv = iv,
            };
            //忽略ca证书认证
            //AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            //runtime.IgnoreSSL = true;
            //return await client.DecryptWithOptionsAsync(request,runtime);
            return await client.DecryptAsync(request);
        }
        private static readonly int GCM_TAG_LENGTH = 16;
        public static void Main(string[] args)
        {
            string regionId = "your-regionId";
            string caFilePath = "your-caFilePath";
            string endpoint = "your-endpoint";
            AlibabaCloud.Dkms.Gcs.OpenApi.Models.Config kmsInstanceConfig = CreateKmsInstanceConfig(AlibabaCloud.DarabonbaEnv.Client.GetEnv("ClientKeyFile"), AlibabaCloud.DarabonbaEnv.Client.GetEnv("Password"), endpoint, caFilePath);
            AlibabaCloud.Dkms.Gcs.Sdk.Client client = CreateClient(kmsInstanceConfig);
            var envelopeCipherPersistObject = getEnvelopeCipherPersistObject();
            var keyId = "your-keyId";
            //decrypt
            AlibabaCloud.Dkms.Gcs.Sdk.Models.DecryptResponse decryptRes = Decrypt(client, keyId, envelopeCipherPersistObject.EncryptedDataKey, envelopeCipherPersistObject.DataKeyIV);
            var key = decryptRes.Plaintext;
            var iv = envelopeCipherPersistObject.Iv;
            var cipherText = envelopeCipherPersistObject.CipherText;

            //使用解密得到的key 解密密文数据
            var plainBytes = decryptData(key, cipherText, iv);
            Console.WriteLine(Encoding.UTF8.GetString(plainBytes).TrimEnd("\r\n\0".ToCharArray()));

        }
        private static byte[] decryptData(byte[] key, byte[] cipherText, byte[] iv)
        {
            GcmBlockCipher cipher = new GcmBlockCipher(new AesFastEngine());
            AeadParameters parameters =
                         new AeadParameters(new KeyParameter(key), GCM_TAG_LENGTH * 8, iv);
            cipher.Init(false, parameters);
            byte[] plainBytes =
                   new byte[cipher.GetOutputSize(cipherText.Length)];
            Int32 retLen = cipher.ProcessBytes
                  (cipherText, 0, cipherText.Length, plainBytes, 0);
            cipher.DoFinal(plainBytes, retLen);
            return plainBytes;
        }

        private static EnvelopeEncryptSample.EnvelopeCipherPersistObject getEnvelopeCipherPersistObject() {
            // TODO 用户需要在此处代码进行替换，从存储中读取封信加密持久化对象
            return new EnvelopeEncryptSample.EnvelopeCipherPersistObject();
        }
    }
}
