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
    public class GetSecretValueSample 
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

        public static AlibabaCloud.Dkms.Gcs.Sdk.Models.GetSecretValueResponse GetSecretValue(AlibabaCloud.Dkms.Gcs.Sdk.Client client, string secretName, string versionStage, bool? fetchExtendedConfig)
        {
            AlibabaCloud.Dkms.Gcs.Sdk.Models.GetSecretValueRequest request = new AlibabaCloud.Dkms.Gcs.Sdk.Models.GetSecretValueRequest
            {
                SecretName = secretName,
                VersionStage = versionStage,
                FetchExtendedConfig = fetchExtendedConfig,
            };
            //忽略ca证书认证
            //AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            //runtime.IgnoreSSL = true;
            //return client.GetSecretValueWithOptions(request,runtime);
            return client.GetSecretValue(request);
        }

        public static async Task<AlibabaCloud.Dkms.Gcs.Sdk.Models.GetSecretValueResponse> GetSecretValueAsync(AlibabaCloud.Dkms.Gcs.Sdk.Client client, string secretName, string versionStage, bool? fetchExtendedConfig)
        {
            AlibabaCloud.Dkms.Gcs.Sdk.Models.GetSecretValueRequest request = new AlibabaCloud.Dkms.Gcs.Sdk.Models.GetSecretValueRequest
            {
                SecretName = secretName,
                VersionStage = versionStage,
                FetchExtendedConfig = fetchExtendedConfig,
            };
            //忽略ca证书认证
            //AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            //runtime.IgnoreSSL = true;
            //return await client.GetSecretValueWithOptionsAsync(request,runtime);
            return await client.GetSecretValueAsync(request);
        }

        public static void Main(string[] args)
        {
            string regionId = "your-regionId";
            string caFilePath = "your-caFilePath";
            string endpoint = "your-endpoint";
            AlibabaCloud.Dkms.Gcs.OpenApi.Models.Config kmsInstanceConfig = CreateKmsInstanceConfig(AlibabaCloud.DarabonbaEnv.Client.GetEnv("ClientKeyFile"), AlibabaCloud.DarabonbaEnv.Client.GetEnv("Password"), endpoint, caFilePath);
            AlibabaCloud.Dkms.Gcs.Sdk.Client client = CreateClient(kmsInstanceConfig);
            //getSecretValue
            string secretName = "your-secretName";
            string versionStage = "your-versionStage";
            bool? fetchExtendedConfig = true;
            AlibabaCloud.Dkms.Gcs.Sdk.Models.GetSecretValueResponse getSecretValueRes = GetSecretValue(client, secretName, versionStage, fetchExtendedConfig);
            string getSecretValueResJson = AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.TeaUtil.Common.ToMap(getSecretValueRes));
            AlibabaCloud.TeaConsole.Client.Log("getSecretValueRes:" + getSecretValueResJson);
        }


    }
}
