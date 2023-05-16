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
    public class GenerateDataKeySample 
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

        public static AlibabaCloud.Dkms.Gcs.Sdk.Models.GenerateDataKeyResponse GenerateDataKey(AlibabaCloud.Dkms.Gcs.Sdk.Client client, string keyId, int? numberOfBytes, byte[] aad)
        {
            AlibabaCloud.Dkms.Gcs.Sdk.Models.GenerateDataKeyRequest request = new AlibabaCloud.Dkms.Gcs.Sdk.Models.GenerateDataKeyRequest
            {
                KeyId = keyId,
                NumberOfBytes = numberOfBytes,
                Aad = aad,
            };
            //忽略ca证书认证
            //AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            //runtime.IgnoreSSL = true;
            //return client.GenerateDataKeyWithOptions(request,runtime);
            return client.GenerateDataKey(request);
        }

        public static async Task<AlibabaCloud.Dkms.Gcs.Sdk.Models.GenerateDataKeyResponse> GenerateDataKeyAsync(AlibabaCloud.Dkms.Gcs.Sdk.Client client, string keyId, int? numberOfBytes, byte[] aad)
        {
            AlibabaCloud.Dkms.Gcs.Sdk.Models.GenerateDataKeyRequest request = new AlibabaCloud.Dkms.Gcs.Sdk.Models.GenerateDataKeyRequest
            {
                KeyId = keyId,
                NumberOfBytes = numberOfBytes,
                Aad = aad,
            };
            //忽略ca证书认证
            //AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            //runtime.IgnoreSSL = true;
            //return await client.GenerateDataKeyWithOptionsAsync(request,runtime);
            return await client.GenerateDataKeyAsync(request);
        }

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
            byte[] aad = AlibabaCloud.DarabonbaEncodeUtil.Encoder.Base64Decode("your-aad-base64");
            AlibabaCloud.Dkms.Gcs.Sdk.Models.GenerateDataKeyResponse generateDataKeyRes = GenerateDataKey(client, keyId, AlibabaCloud.DarabonbaNumber.NumberUtil.ParseInt(numberOfBytes), aad);


        }
       
    }
}
