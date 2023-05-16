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
    public class AsymmetricSignVerifySample 
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

        public static AlibabaCloud.Dkms.Gcs.Sdk.Models.SignResponse Sign(AlibabaCloud.Dkms.Gcs.Sdk.Client client, string keyId, string algorithm, byte[] message, string messageType)
        {
            AlibabaCloud.Dkms.Gcs.Sdk.Models.SignRequest request = new AlibabaCloud.Dkms.Gcs.Sdk.Models.SignRequest
            {
                KeyId = keyId,
                Algorithm = algorithm,
                Message = message,
                MessageType = messageType,
            };
            //忽略ca证书认证
            //AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            //runtime.IgnoreSSL = true;
            //return client.SigntWithOptions(request,runtime);
            return client.Sign(request);
        }

        public static async Task<AlibabaCloud.Dkms.Gcs.Sdk.Models.SignResponse> SignAsync(AlibabaCloud.Dkms.Gcs.Sdk.Client client, string keyId, string algorithm, byte[] message, string messageType)
        {
            AlibabaCloud.Dkms.Gcs.Sdk.Models.SignRequest request = new AlibabaCloud.Dkms.Gcs.Sdk.Models.SignRequest
            {
                KeyId = keyId,
                Algorithm = algorithm,
                Message = message,
                MessageType = messageType,
            };
            //忽略ca证书认证
            //AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            //runtime.IgnoreSSL = true;
            //return await client.SignWithOptionsAsync(request,runtime);
            return await client.SignAsync(request);
        }

        public static AlibabaCloud.Dkms.Gcs.Sdk.Models.VerifyResponse Verify(AlibabaCloud.Dkms.Gcs.Sdk.Client client, string keyId, string algorithm, byte[] message, string messageType, byte[] signature)
        {
            AlibabaCloud.Dkms.Gcs.Sdk.Models.VerifyRequest request = new AlibabaCloud.Dkms.Gcs.Sdk.Models.VerifyRequest
            {
                KeyId = keyId,
                Algorithm = algorithm,
                Message = message,
                MessageType = messageType,
                Signature = signature,
            };
            //忽略ca证书认证
            //AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            //runtime.IgnoreSSL = true;
            //return client.VerifyWithOptions(request,runtime);
            return client.Verify(request);
        }

        public static async Task<AlibabaCloud.Dkms.Gcs.Sdk.Models.VerifyResponse> VerifyAsync(AlibabaCloud.Dkms.Gcs.Sdk.Client client, string keyId, string algorithm, byte[] message, string messageType, byte[] signature)
        {
            AlibabaCloud.Dkms.Gcs.Sdk.Models.VerifyRequest request = new AlibabaCloud.Dkms.Gcs.Sdk.Models.VerifyRequest
            {
                KeyId = keyId,
                Algorithm = algorithm,
                Message = message,
                MessageType = messageType,
                Signature = signature,
            };
            //忽略ca证书认证
            //AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            //runtime.IgnoreSSL = true;
            //return await client.VerifWithOptionsAsync(request,runtime);
            return await client.VerifyAsync(request);
        }

        public static void Main(string[] args)
        {
            string regionId = "your-regionId";
            string caFilePath = "your-caFilePath";
            string endpoint = "your-endpoint";
            AlibabaCloud.Dkms.Gcs.OpenApi.Models.Config kmsInstanceConfig = CreateKmsInstanceConfig(AlibabaCloud.DarabonbaEnv.Client.GetEnv("ClientKeyFile"), AlibabaCloud.DarabonbaEnv.Client.GetEnv("Password"), endpoint, caFilePath);
            AlibabaCloud.Dkms.Gcs.Sdk.Client client = CreateClient(kmsInstanceConfig);
            //sign
            string keyId = "your-keyId";
            string algorithm = "your-algorithm";
            byte[] message = AlibabaCloud.DarabonbaEncodeUtil.Encoder.Base64Decode("your-message-base64");
            string messageType = "your-messageType";
            AlibabaCloud.Dkms.Gcs.Sdk.Models.SignResponse signRes = Sign(client, keyId, algorithm, message, messageType);
            //verify
            AlibabaCloud.Dkms.Gcs.Sdk.Models.VerifyResponse verifyRes = Verify(client, signRes.KeyId, signRes.Algorithm, message, signRes.MessageType, signRes.Signature);
            string verifyResJson = AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.TeaUtil.Common.ToMap(verifyRes));
            AlibabaCloud.TeaConsole.Client.Log("verifyRes:" + verifyResJson);
        }


    }
}
