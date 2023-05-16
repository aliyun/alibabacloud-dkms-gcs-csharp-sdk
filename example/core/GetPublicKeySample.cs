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
    public class GetPublicKeySample 
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

        public static AlibabaCloud.Dkms.Gcs.Sdk.Models.GetPublicKeyResponse GetPublicKey(AlibabaCloud.Dkms.Gcs.Sdk.Client client, string keyId)
        {
            AlibabaCloud.Dkms.Gcs.Sdk.Models.GetPublicKeyRequest request = new AlibabaCloud.Dkms.Gcs.Sdk.Models.GetPublicKeyRequest
            {
                KeyId = keyId,
            };
            //忽略ca证书认证
            //AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            //runtime.IgnoreSSL = true;
            //return client.GetPublicKeyWithOptions(request,runtime);
            return client.GetPublicKey(request);
        }

        public static async Task<AlibabaCloud.Dkms.Gcs.Sdk.Models.GetPublicKeyResponse> GetPublicKeyAsync(AlibabaCloud.Dkms.Gcs.Sdk.Client client, string keyId)
        {
            AlibabaCloud.Dkms.Gcs.Sdk.Models.GetPublicKeyRequest request = new AlibabaCloud.Dkms.Gcs.Sdk.Models.GetPublicKeyRequest
            {
                KeyId = keyId,
            };
            //忽略ca证书认证
            //AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            //runtime.IgnoreSSL = true;
            //return await client.GetPublicKeyWithOptionsAsync(request,runtime);
            return await client.GetPublicKeyAsync(request);
        }

        public static void Main(string[] args)
        {
            string regionId = "your-regionId";
            string caFilePath = "your-caFilePath";
            string endpoint = "your-endpoint";
            AlibabaCloud.Dkms.Gcs.OpenApi.Models.Config kmsInstanceConfig = CreateKmsInstanceConfig(AlibabaCloud.DarabonbaEnv.Client.GetEnv("ClientKeyFile"), AlibabaCloud.DarabonbaEnv.Client.GetEnv("Password"), endpoint, caFilePath);
            AlibabaCloud.Dkms.Gcs.Sdk.Client client = CreateClient(kmsInstanceConfig);
            //getPublicKey
            string keyId = "your-keyId";
            AlibabaCloud.Dkms.Gcs.Sdk.Models.GetPublicKeyResponse getPublicKeyRes = GetPublicKey(client, keyId);
            string getPublicKeyResJson = AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.TeaUtil.Common.ToMap(getPublicKeyRes));
            AlibabaCloud.TeaConsole.Client.Log("getPublicKeyRes:" + getPublicKeyResJson);
        }


    }
}
