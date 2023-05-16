// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.Dkms.Gcs.Sdk.Models;

namespace AlibabaCloud.Dkms.Gcs.Sdk
{
    public class Client : AlibabaCloud.Dkms.Gcs.OpenApi.Client
    {

        public Client(AlibabaCloud.Dkms.Gcs.OpenApi.Models.Config config): base(config)
        {
        }

        public EncryptResponse Encrypt(EncryptRequest request)
        {
            AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            return EncryptWithOptions(request, runtime);
        }

        public async Task<EncryptResponse> EncryptAsync(EncryptRequest request)
        {
            AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            return await EncryptWithOptionsAsync(request, runtime);
        }

        public EncryptResponse EncryptWithOptions(EncryptRequest request, AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> reqBody = AlibabaCloud.TeaUtil.Common.ToMap(request);
            byte[] reqBodyBytes = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetSerializedEncryptRequest(reqBody);
            Dictionary<string, object> responseEntity = AlibabaCloud.TeaUtil.Common.AssertAsMap(DoRequest("Encrypt", "dkms-gcs-0.2", "https", "POST", "RSA_PKCS1_SHA_256", reqBodyBytes, runtime, request.RequestHeaders));
            Dictionary<string, object> respMap = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.ParseEncryptResponse(AlibabaCloud.TeaUtil.Common.AssertAsBytes(responseEntity.Get("bodyBytes")));
            return TeaModel.ToObject<EncryptResponse>(new Dictionary<string, object>
            {
                {"KeyId", respMap.Get("KeyId")},
                {"CiphertextBlob", respMap.Get("CiphertextBlob")},
                {"Iv", respMap.Get("Iv")},
                {"RequestId", respMap.Get("RequestId")},
                {"Algorithm", respMap.Get("Algorithm")},
                {"PaddingMode", respMap.Get("PaddingMode")},
                {"responseHeaders", responseEntity.Get("responseHeaders")},
            });
        }

        public async Task<EncryptResponse> EncryptWithOptionsAsync(EncryptRequest request, AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> reqBody = AlibabaCloud.TeaUtil.Common.ToMap(request);
            byte[] reqBodyBytes = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetSerializedEncryptRequest(reqBody);
            Dictionary<string, object> responseEntity = AlibabaCloud.TeaUtil.Common.AssertAsMap(await DoRequestAsync("Encrypt", "dkms-gcs-0.2", "https", "POST", "RSA_PKCS1_SHA_256", reqBodyBytes, runtime, request.RequestHeaders));
            Dictionary<string, object> respMap = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.ParseEncryptResponse(AlibabaCloud.TeaUtil.Common.AssertAsBytes(responseEntity.Get("bodyBytes")));
            return TeaModel.ToObject<EncryptResponse>(new Dictionary<string, object>
            {
                {"KeyId", respMap.Get("KeyId")},
                {"CiphertextBlob", respMap.Get("CiphertextBlob")},
                {"Iv", respMap.Get("Iv")},
                {"RequestId", respMap.Get("RequestId")},
                {"Algorithm", respMap.Get("Algorithm")},
                {"PaddingMode", respMap.Get("PaddingMode")},
                {"responseHeaders", responseEntity.Get("responseHeaders")},
            });
        }

        public DecryptResponse Decrypt(DecryptRequest request)
        {
            AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            return DecryptWithOptions(request, runtime);
        }

        public async Task<DecryptResponse> DecryptAsync(DecryptRequest request)
        {
            AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            return await DecryptWithOptionsAsync(request, runtime);
        }

        public DecryptResponse DecryptWithOptions(DecryptRequest request, AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> reqBody = AlibabaCloud.TeaUtil.Common.ToMap(request);
            byte[] reqBodyBytes = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetSerializedDecryptRequest(reqBody);
            Dictionary<string, object> responseEntity = AlibabaCloud.TeaUtil.Common.AssertAsMap(DoRequest("Decrypt", "dkms-gcs-0.2", "https", "POST", "RSA_PKCS1_SHA_256", reqBodyBytes, runtime, request.RequestHeaders));
            Dictionary<string, object> respMap = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.ParseDecryptResponse(AlibabaCloud.TeaUtil.Common.AssertAsBytes(responseEntity.Get("bodyBytes")));
            return TeaModel.ToObject<DecryptResponse>(new Dictionary<string, object>
            {
                {"KeyId", respMap.Get("KeyId")},
                {"Plaintext", respMap.Get("Plaintext")},
                {"RequestId", respMap.Get("RequestId")},
                {"Algorithm", respMap.Get("Algorithm")},
                {"PaddingMode", respMap.Get("PaddingMode")},
                {"responseHeaders", responseEntity.Get("responseHeaders")},
            });
        }

        public async Task<DecryptResponse> DecryptWithOptionsAsync(DecryptRequest request, AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> reqBody = AlibabaCloud.TeaUtil.Common.ToMap(request);
            byte[] reqBodyBytes = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetSerializedDecryptRequest(reqBody);
            Dictionary<string, object> responseEntity = AlibabaCloud.TeaUtil.Common.AssertAsMap(await DoRequestAsync("Decrypt", "dkms-gcs-0.2", "https", "POST", "RSA_PKCS1_SHA_256", reqBodyBytes, runtime, request.RequestHeaders));
            Dictionary<string, object> respMap = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.ParseDecryptResponse(AlibabaCloud.TeaUtil.Common.AssertAsBytes(responseEntity.Get("bodyBytes")));
            return TeaModel.ToObject<DecryptResponse>(new Dictionary<string, object>
            {
                {"KeyId", respMap.Get("KeyId")},
                {"Plaintext", respMap.Get("Plaintext")},
                {"RequestId", respMap.Get("RequestId")},
                {"Algorithm", respMap.Get("Algorithm")},
                {"PaddingMode", respMap.Get("PaddingMode")},
                {"responseHeaders", responseEntity.Get("responseHeaders")},
            });
        }

        public SignResponse Sign(SignRequest request)
        {
            AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            return SignWithOptions(request, runtime);
        }

        public async Task<SignResponse> SignAsync(SignRequest request)
        {
            AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            return await SignWithOptionsAsync(request, runtime);
        }

        public SignResponse SignWithOptions(SignRequest request, AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> reqBody = AlibabaCloud.TeaUtil.Common.ToMap(request);
            byte[] reqBodyBytes = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetSerializedSignRequest(reqBody);
            Dictionary<string, object> responseEntity = AlibabaCloud.TeaUtil.Common.AssertAsMap(DoRequest("Sign", "dkms-gcs-0.2", "https", "POST", "RSA_PKCS1_SHA_256", reqBodyBytes, runtime, request.RequestHeaders));
            Dictionary<string, object> respMap = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.ParseSignResponse(AlibabaCloud.TeaUtil.Common.AssertAsBytes(responseEntity.Get("bodyBytes")));
            return TeaModel.ToObject<SignResponse>(new Dictionary<string, object>
            {
                {"KeyId", respMap.Get("KeyId")},
                {"Signature", respMap.Get("Signature")},
                {"RequestId", respMap.Get("RequestId")},
                {"Algorithm", respMap.Get("Algorithm")},
                {"MessageType", respMap.Get("MessageType")},
                {"responseHeaders", responseEntity.Get("responseHeaders")},
            });
        }

        public async Task<SignResponse> SignWithOptionsAsync(SignRequest request, AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> reqBody = AlibabaCloud.TeaUtil.Common.ToMap(request);
            byte[] reqBodyBytes = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetSerializedSignRequest(reqBody);
            Dictionary<string, object> responseEntity = AlibabaCloud.TeaUtil.Common.AssertAsMap(await DoRequestAsync("Sign", "dkms-gcs-0.2", "https", "POST", "RSA_PKCS1_SHA_256", reqBodyBytes, runtime, request.RequestHeaders));
            Dictionary<string, object> respMap = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.ParseSignResponse(AlibabaCloud.TeaUtil.Common.AssertAsBytes(responseEntity.Get("bodyBytes")));
            return TeaModel.ToObject<SignResponse>(new Dictionary<string, object>
            {
                {"KeyId", respMap.Get("KeyId")},
                {"Signature", respMap.Get("Signature")},
                {"RequestId", respMap.Get("RequestId")},
                {"Algorithm", respMap.Get("Algorithm")},
                {"MessageType", respMap.Get("MessageType")},
                {"responseHeaders", responseEntity.Get("responseHeaders")},
            });
        }

        public VerifyResponse Verify(VerifyRequest request)
        {
            AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            return VerifyWithOptions(request, runtime);
        }

        public async Task<VerifyResponse> VerifyAsync(VerifyRequest request)
        {
            AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            return await VerifyWithOptionsAsync(request, runtime);
        }

        public VerifyResponse VerifyWithOptions(VerifyRequest request, AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> reqBody = AlibabaCloud.TeaUtil.Common.ToMap(request);
            byte[] reqBodyBytes = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetSerializedVerifyRequest(reqBody);
            Dictionary<string, object> responseEntity = AlibabaCloud.TeaUtil.Common.AssertAsMap(DoRequest("Verify", "dkms-gcs-0.2", "https", "POST", "RSA_PKCS1_SHA_256", reqBodyBytes, runtime, request.RequestHeaders));
            Dictionary<string, object> respMap = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.ParseVerifyResponse(AlibabaCloud.TeaUtil.Common.AssertAsBytes(responseEntity.Get("bodyBytes")));
            return TeaModel.ToObject<VerifyResponse>(new Dictionary<string, object>
            {
                {"KeyId", respMap.Get("KeyId")},
                {"Value", respMap.Get("Value")},
                {"RequestId", respMap.Get("RequestId")},
                {"Algorithm", respMap.Get("Algorithm")},
                {"MessageType", respMap.Get("MessageType")},
                {"responseHeaders", responseEntity.Get("responseHeaders")},
            });
        }

        public async Task<VerifyResponse> VerifyWithOptionsAsync(VerifyRequest request, AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> reqBody = AlibabaCloud.TeaUtil.Common.ToMap(request);
            byte[] reqBodyBytes = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetSerializedVerifyRequest(reqBody);
            Dictionary<string, object> responseEntity = AlibabaCloud.TeaUtil.Common.AssertAsMap(await DoRequestAsync("Verify", "dkms-gcs-0.2", "https", "POST", "RSA_PKCS1_SHA_256", reqBodyBytes, runtime, request.RequestHeaders));
            Dictionary<string, object> respMap = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.ParseVerifyResponse(AlibabaCloud.TeaUtil.Common.AssertAsBytes(responseEntity.Get("bodyBytes")));
            return TeaModel.ToObject<VerifyResponse>(new Dictionary<string, object>
            {
                {"KeyId", respMap.Get("KeyId")},
                {"Value", respMap.Get("Value")},
                {"RequestId", respMap.Get("RequestId")},
                {"Algorithm", respMap.Get("Algorithm")},
                {"MessageType", respMap.Get("MessageType")},
                {"responseHeaders", responseEntity.Get("responseHeaders")},
            });
        }

        public HmacResponse Hmac(HmacRequest request)
        {
            AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            return HmacWithOptions(request, runtime);
        }

        public async Task<HmacResponse> HmacAsync(HmacRequest request)
        {
            AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            return await HmacWithOptionsAsync(request, runtime);
        }

        public HmacResponse HmacWithOptions(HmacRequest request, AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> reqBody = AlibabaCloud.TeaUtil.Common.ToMap(request);
            byte[] reqBodyBytes = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetSerializedHmacRequest(reqBody);
            Dictionary<string, object> responseEntity = AlibabaCloud.TeaUtil.Common.AssertAsMap(DoRequest("Hmac", "dkms-gcs-0.2", "https", "POST", "RSA_PKCS1_SHA_256", reqBodyBytes, runtime, request.RequestHeaders));
            Dictionary<string, object> respMap = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.ParseHmacResponse(AlibabaCloud.TeaUtil.Common.AssertAsBytes(responseEntity.Get("bodyBytes")));
            return TeaModel.ToObject<HmacResponse>(new Dictionary<string, object>
            {
                {"KeyId", respMap.Get("KeyId")},
                {"Signature", respMap.Get("Signature")},
                {"RequestId", respMap.Get("RequestId")},
                {"responseHeaders", responseEntity.Get("responseHeaders")},
            });
        }

        public async Task<HmacResponse> HmacWithOptionsAsync(HmacRequest request, AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> reqBody = AlibabaCloud.TeaUtil.Common.ToMap(request);
            byte[] reqBodyBytes = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetSerializedHmacRequest(reqBody);
            Dictionary<string, object> responseEntity = AlibabaCloud.TeaUtil.Common.AssertAsMap(await DoRequestAsync("Hmac", "dkms-gcs-0.2", "https", "POST", "RSA_PKCS1_SHA_256", reqBodyBytes, runtime, request.RequestHeaders));
            Dictionary<string, object> respMap = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.ParseHmacResponse(AlibabaCloud.TeaUtil.Common.AssertAsBytes(responseEntity.Get("bodyBytes")));
            return TeaModel.ToObject<HmacResponse>(new Dictionary<string, object>
            {
                {"KeyId", respMap.Get("KeyId")},
                {"Signature", respMap.Get("Signature")},
                {"RequestId", respMap.Get("RequestId")},
                {"responseHeaders", responseEntity.Get("responseHeaders")},
            });
        }

        public GenerateRandomResponse GenerateRandom(GenerateRandomRequest request)
        {
            AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            return GenerateRandomWithOptions(request, runtime);
        }

        public async Task<GenerateRandomResponse> GenerateRandomAsync(GenerateRandomRequest request)
        {
            AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            return await GenerateRandomWithOptionsAsync(request, runtime);
        }

        public GenerateRandomResponse GenerateRandomWithOptions(GenerateRandomRequest request, AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> reqBody = AlibabaCloud.TeaUtil.Common.ToMap(request);
            byte[] reqBodyBytes = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetSerializedGenerateRandomRequest(reqBody);
            Dictionary<string, object> responseEntity = AlibabaCloud.TeaUtil.Common.AssertAsMap(DoRequest("GenerateRandom", "dkms-gcs-0.2", "https", "POST", "RSA_PKCS1_SHA_256", reqBodyBytes, runtime, request.RequestHeaders));
            Dictionary<string, object> respMap = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.ParseGenerateRandomResponse(AlibabaCloud.TeaUtil.Common.AssertAsBytes(responseEntity.Get("bodyBytes")));
            return TeaModel.ToObject<GenerateRandomResponse>(new Dictionary<string, object>
            {
                {"Random", respMap.Get("Random")},
                {"RequestId", respMap.Get("RequestId")},
                {"responseHeaders", responseEntity.Get("responseHeaders")},
            });
        }

        public async Task<GenerateRandomResponse> GenerateRandomWithOptionsAsync(GenerateRandomRequest request, AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> reqBody = AlibabaCloud.TeaUtil.Common.ToMap(request);
            byte[] reqBodyBytes = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetSerializedGenerateRandomRequest(reqBody);
            Dictionary<string, object> responseEntity = AlibabaCloud.TeaUtil.Common.AssertAsMap(await DoRequestAsync("GenerateRandom", "dkms-gcs-0.2", "https", "POST", "RSA_PKCS1_SHA_256", reqBodyBytes, runtime, request.RequestHeaders));
            Dictionary<string, object> respMap = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.ParseGenerateRandomResponse(AlibabaCloud.TeaUtil.Common.AssertAsBytes(responseEntity.Get("bodyBytes")));
            return TeaModel.ToObject<GenerateRandomResponse>(new Dictionary<string, object>
            {
                {"Random", respMap.Get("Random")},
                {"RequestId", respMap.Get("RequestId")},
                {"responseHeaders", responseEntity.Get("responseHeaders")},
            });
        }

        public GenerateDataKeyResponse GenerateDataKey(GenerateDataKeyRequest request)
        {
            AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            return GenerateDataKeyWithOptions(request, runtime);
        }

        public async Task<GenerateDataKeyResponse> GenerateDataKeyAsync(GenerateDataKeyRequest request)
        {
            AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            return await GenerateDataKeyWithOptionsAsync(request, runtime);
        }

        public GenerateDataKeyResponse GenerateDataKeyWithOptions(GenerateDataKeyRequest request, AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> reqBody = AlibabaCloud.TeaUtil.Common.ToMap(request);
            byte[] reqBodyBytes = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetSerializedGenerateDataKeyRequest(reqBody);
            Dictionary<string, object> responseEntity = AlibabaCloud.TeaUtil.Common.AssertAsMap(DoRequest("GenerateDataKey", "dkms-gcs-0.2", "https", "POST", "RSA_PKCS1_SHA_256", reqBodyBytes, runtime, request.RequestHeaders));
            Dictionary<string, object> respMap = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.ParseGenerateDataKeyResponse(AlibabaCloud.TeaUtil.Common.AssertAsBytes(responseEntity.Get("bodyBytes")));
            return TeaModel.ToObject<GenerateDataKeyResponse>(new Dictionary<string, object>
            {
                {"KeyId", respMap.Get("KeyId")},
                {"Iv", respMap.Get("Iv")},
                {"Plaintext", respMap.Get("Plaintext")},
                {"CiphertextBlob", respMap.Get("CiphertextBlob")},
                {"RequestId", respMap.Get("RequestId")},
                {"Algorithm", respMap.Get("Algorithm")},
                {"responseHeaders", responseEntity.Get("responseHeaders")},
            });
        }

        public async Task<GenerateDataKeyResponse> GenerateDataKeyWithOptionsAsync(GenerateDataKeyRequest request, AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> reqBody = AlibabaCloud.TeaUtil.Common.ToMap(request);
            byte[] reqBodyBytes = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetSerializedGenerateDataKeyRequest(reqBody);
            Dictionary<string, object> responseEntity = AlibabaCloud.TeaUtil.Common.AssertAsMap(await DoRequestAsync("GenerateDataKey", "dkms-gcs-0.2", "https", "POST", "RSA_PKCS1_SHA_256", reqBodyBytes, runtime, request.RequestHeaders));
            Dictionary<string, object> respMap = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.ParseGenerateDataKeyResponse(AlibabaCloud.TeaUtil.Common.AssertAsBytes(responseEntity.Get("bodyBytes")));
            return TeaModel.ToObject<GenerateDataKeyResponse>(new Dictionary<string, object>
            {
                {"KeyId", respMap.Get("KeyId")},
                {"Iv", respMap.Get("Iv")},
                {"Plaintext", respMap.Get("Plaintext")},
                {"CiphertextBlob", respMap.Get("CiphertextBlob")},
                {"RequestId", respMap.Get("RequestId")},
                {"Algorithm", respMap.Get("Algorithm")},
                {"responseHeaders", responseEntity.Get("responseHeaders")},
            });
        }

        public GetPublicKeyResponse GetPublicKey(GetPublicKeyRequest request)
        {
            AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            return GetPublicKeyWithOptions(request, runtime);
        }

        public async Task<GetPublicKeyResponse> GetPublicKeyAsync(GetPublicKeyRequest request)
        {
            AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            return await GetPublicKeyWithOptionsAsync(request, runtime);
        }

        public GetPublicKeyResponse GetPublicKeyWithOptions(GetPublicKeyRequest request, AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> reqBody = AlibabaCloud.TeaUtil.Common.ToMap(request);
            byte[] reqBodyBytes = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetSerializedGetPublicKeyRequest(reqBody);
            Dictionary<string, object> responseEntity = AlibabaCloud.TeaUtil.Common.AssertAsMap(DoRequest("GetPublicKey", "dkms-gcs-0.2", "https", "POST", "RSA_PKCS1_SHA_256", reqBodyBytes, runtime, request.RequestHeaders));
            Dictionary<string, object> respMap = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.ParseGetPublicKeyResponse(AlibabaCloud.TeaUtil.Common.AssertAsBytes(responseEntity.Get("bodyBytes")));
            return TeaModel.ToObject<GetPublicKeyResponse>(new Dictionary<string, object>
            {
                {"KeyId", respMap.Get("KeyId")},
                {"PublicKey", respMap.Get("PublicKey")},
                {"RequestId", respMap.Get("RequestId")},
                {"responseHeaders", responseEntity.Get("responseHeaders")},
            });
        }

        public async Task<GetPublicKeyResponse> GetPublicKeyWithOptionsAsync(GetPublicKeyRequest request, AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> reqBody = AlibabaCloud.TeaUtil.Common.ToMap(request);
            byte[] reqBodyBytes = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetSerializedGetPublicKeyRequest(reqBody);
            Dictionary<string, object> responseEntity = AlibabaCloud.TeaUtil.Common.AssertAsMap(await DoRequestAsync("GetPublicKey", "dkms-gcs-0.2", "https", "POST", "RSA_PKCS1_SHA_256", reqBodyBytes, runtime, request.RequestHeaders));
            Dictionary<string, object> respMap = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.ParseGetPublicKeyResponse(AlibabaCloud.TeaUtil.Common.AssertAsBytes(responseEntity.Get("bodyBytes")));
            return TeaModel.ToObject<GetPublicKeyResponse>(new Dictionary<string, object>
            {
                {"KeyId", respMap.Get("KeyId")},
                {"PublicKey", respMap.Get("PublicKey")},
                {"RequestId", respMap.Get("RequestId")},
                {"responseHeaders", responseEntity.Get("responseHeaders")},
            });
        }

        public GetSecretValueResponse GetSecretValue(GetSecretValueRequest request)
        {
            AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            return GetSecretValueWithOptions(request, runtime);
        }

        public async Task<GetSecretValueResponse> GetSecretValueAsync(GetSecretValueRequest request)
        {
            AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime = new AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions();
            return await GetSecretValueWithOptionsAsync(request, runtime);
        }

        public GetSecretValueResponse GetSecretValueWithOptions(GetSecretValueRequest request, AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> reqBody = AlibabaCloud.TeaUtil.Common.ToMap(request);
            byte[] reqBodyBytes = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetSerializedGetSecretValueRequest(reqBody);
            Dictionary<string, object> responseEntity = AlibabaCloud.TeaUtil.Common.AssertAsMap(DoRequest("GetSecretValue", "dkms-gcs-0.2", "https", "POST", "RSA_PKCS1_SHA_256", reqBodyBytes, runtime, request.RequestHeaders));
            Dictionary<string, object> respMap = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.ParseGetSecretValueResponse(AlibabaCloud.TeaUtil.Common.AssertAsBytes(responseEntity.Get("bodyBytes")));
            return TeaModel.ToObject<GetSecretValueResponse>(new Dictionary<string, object>
            {
                {"SecretName", respMap.Get("SecretName")},
                {"SecretType", respMap.Get("SecretType")},
                {"SecretData", respMap.Get("SecretData")},
                {"SecretDataType", respMap.Get("SecretDataType")},
                {"VersionStages", respMap.Get("VersionStages")},
                {"VersionId", respMap.Get("VersionId")},
                {"CreateTime", respMap.Get("CreateTime")},
                {"RequestId", respMap.Get("RequestId")},
                {"LastRotationDate", respMap.Get("LastRotationDate")},
                {"NextRotationDate", respMap.Get("NextRotationDate")},
                {"ExtendedConfig", respMap.Get("ExtendedConfig")},
                {"AutomaticRotation", respMap.Get("AutomaticRotation")},
                {"RotationInterval", respMap.Get("RotationInterval")},
                {"responseHeaders", responseEntity.Get("responseHeaders")},
            });
        }

        public async Task<GetSecretValueResponse> GetSecretValueWithOptionsAsync(GetSecretValueRequest request, AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> reqBody = AlibabaCloud.TeaUtil.Common.ToMap(request);
            byte[] reqBodyBytes = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetSerializedGetSecretValueRequest(reqBody);
            Dictionary<string, object> responseEntity = AlibabaCloud.TeaUtil.Common.AssertAsMap(await DoRequestAsync("GetSecretValue", "dkms-gcs-0.2", "https", "POST", "RSA_PKCS1_SHA_256", reqBodyBytes, runtime, request.RequestHeaders));
            Dictionary<string, object> respMap = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.ParseGetSecretValueResponse(AlibabaCloud.TeaUtil.Common.AssertAsBytes(responseEntity.Get("bodyBytes")));
            return TeaModel.ToObject<GetSecretValueResponse>(new Dictionary<string, object>
            {
                {"SecretName", respMap.Get("SecretName")},
                {"SecretType", respMap.Get("SecretType")},
                {"SecretData", respMap.Get("SecretData")},
                {"SecretDataType", respMap.Get("SecretDataType")},
                {"VersionStages", respMap.Get("VersionStages")},
                {"VersionId", respMap.Get("VersionId")},
                {"CreateTime", respMap.Get("CreateTime")},
                {"RequestId", respMap.Get("RequestId")},
                {"LastRotationDate", respMap.Get("LastRotationDate")},
                {"NextRotationDate", respMap.Get("NextRotationDate")},
                {"ExtendedConfig", respMap.Get("ExtendedConfig")},
                {"AutomaticRotation", respMap.Get("AutomaticRotation")},
                {"RotationInterval", respMap.Get("RotationInterval")},
                {"responseHeaders", responseEntity.Get("responseHeaders")},
            });
        }

    }
}
