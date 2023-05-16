// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;


namespace AlibabaCloud.Dkms.Gcs.Sdk.Example
{
    public class AsymmetricEncryptDecryptSample 
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

        public static AlibabaCloud.Dkms.Gcs.Sdk.Models.EncryptResponse Encrypt(AlibabaCloud.Dkms.Gcs.Sdk.Client client, byte[] plaintext, string keyId, string algorithm)
        {
            AlibabaCloud.Dkms.Gcs.Sdk.Models.EncryptRequest request = new AlibabaCloud.Dkms.Gcs.Sdk.Models.EncryptRequest
            {
                Plaintext = plaintext,
                KeyId = keyId,
                Algorithm = algorithm,
            };
            //忽略ca证书认证
            //AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            //runtime.IgnoreSSL = true;
            //return client.EncryptWithOptions(request,runtime);
            return client.Encrypt(request);
        }

        public static async Task<AlibabaCloud.Dkms.Gcs.Sdk.Models.EncryptResponse> EncryptAsync(AlibabaCloud.Dkms.Gcs.Sdk.Client client, byte[] plaintext, string keyId, string algorithm)
        {
            AlibabaCloud.Dkms.Gcs.Sdk.Models.EncryptRequest request = new AlibabaCloud.Dkms.Gcs.Sdk.Models.EncryptRequest
            {
                Plaintext = plaintext,
                KeyId = keyId,
                Algorithm = algorithm,
            };
            //忽略ca证书认证
            //AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            //runtime.IgnoreSSL = true;
            //return await client.EncryptWithOptionsAsync(request,runtime);
            return await client.EncryptAsync(request);
        }

        public static AlibabaCloud.Dkms.Gcs.Sdk.Models.DecryptResponse Decrypt(AlibabaCloud.Dkms.Gcs.Sdk.Client client, string keyId, byte[] ciphertextBlob, string algorithm)
        {
            AlibabaCloud.Dkms.Gcs.Sdk.Models.DecryptRequest request = new AlibabaCloud.Dkms.Gcs.Sdk.Models.DecryptRequest
            {
                KeyId = keyId,
                CiphertextBlob = ciphertextBlob,
                Algorithm = algorithm,
            };
            //忽略ca证书认证
            //AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            //runtime.IgnoreSSL = true;
            //return client.DecryptWithOptions(request,runtime);
            return client.Decrypt(request);
        }

        public static async Task<AlibabaCloud.Dkms.Gcs.Sdk.Models.DecryptResponse> DecryptAsync(AlibabaCloud.Dkms.Gcs.Sdk.Client client, string keyId, byte[] ciphertextBlob, string algorithm)
        {
            AlibabaCloud.Dkms.Gcs.Sdk.Models.DecryptRequest request = new AlibabaCloud.Dkms.Gcs.Sdk.Models.DecryptRequest
            {
                KeyId = keyId,
                CiphertextBlob = ciphertextBlob,
                Algorithm = algorithm,
            };
            //忽略ca证书认证
            //AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            //runtime.IgnoreSSL = true;
            //return await client.DecryptWithOptionsAsync(request,runtime);
            return await client.DecryptAsync(request);
        }

        public static void Main(string[] args)
        {
            string regionId = "your-regionId";
            string caFilePath = "your-caFilePath";
            string endpoint = "your-endpoint";
            AlibabaCloud.Dkms.Gcs.OpenApi.Models.Config kmsInstanceConfig = CreateKmsInstanceConfig(AlibabaCloud.DarabonbaEnv.Client.GetEnv("ClientKeyFile"), AlibabaCloud.DarabonbaEnv.Client.GetEnv("Password"), endpoint, caFilePath);
            AlibabaCloud.Dkms.Gcs.Sdk.Client client = CreateClient(kmsInstanceConfig);
            //encrypt
            byte[] plaintext = AlibabaCloud.DarabonbaEncodeUtil.Encoder.Base64Decode("your-plaintext-base64");
            string keyId = "your-keyId";
            string algorithm = "your-algorithm";
            AlibabaCloud.Dkms.Gcs.Sdk.Models.EncryptResponse encryptRes = Encrypt(client, plaintext, keyId, algorithm);
            //decrypt
            AlibabaCloud.Dkms.Gcs.Sdk.Models.DecryptResponse decryptRes = Decrypt(client, encryptRes.KeyId, encryptRes.CiphertextBlob, encryptRes.Algorithm);
            string decryptResJson = AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.TeaUtil.Common.ToMap(decryptRes));
            AlibabaCloud.TeaConsole.Client.Log("decryptRes:" + decryptResJson);
        }


    }
}
