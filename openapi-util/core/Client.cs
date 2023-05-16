// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models;
using Google.Protobuf;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

namespace AlibabaCloud.Dkms.Gcs.OpenApiUtil
{
    public class Client 
    {

        public static Dictionary<string, object> GetErrMessage(byte[] msg)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            Error response = Error.Parser.ParseFrom(msg);
            result.Add("Code", response.ErrorCode);
            result.Add("Message", response.ErrorMessage);
            result.Add("RequestId", response.RequestId);
            return result;
            
        }

        public static string GetContentLength(byte[] reqBody)
        {
           if (reqBody == null)
            {
                return "0";
            }
            return reqBody.Length.ToSafeString();
            
        }

        public static string GetStringToSign(string method, string pathname, Dictionary<string, string> headers, Dictionary<string, string> query)
        {
            string contentSHA256 = headers.Get("content-sha256");
            if (AlibabaCloud.TeaUtil.Common.IsUnset(contentSHA256))
            {
                contentSHA256 = "";
            }
            string contentType = headers.Get("content-type");
            if (AlibabaCloud.TeaUtil.Common.IsUnset(contentType))
            {
                contentType = "";
            }
            string date = headers.Get("date");
            if (AlibabaCloud.TeaUtil.Common.IsUnset(date))
            {
                date = "";
            }
            string header = "" + method + "\n" + contentSHA256 + "\n" + contentType + "\n" + date + "\n";
            string canonicalizedHeaders = GetCanonicalizedHeaders(headers);
            string canonicalizedResource = GetCanonicalizedResource(pathname, query);
            return "" + header + canonicalizedHeaders + canonicalizedResource;
        }

        public static string GetCanonicalizedHeaders(Dictionary<string, string> headers)
        {
            if (AlibabaCloud.TeaUtil.Common.IsUnset(headers))
            {
                return null;
            }
            string prefix = "x-kms-";
            List<string> keys = AlibabaCloud.DarabonbaMap.MapUtil.KeySet(headers);
            List<string> sortedKeys = AlibabaCloud.DarabonbaArray.ArrayUtil.AscSort(keys);
            string canonicalizedHeaders = "";

            foreach (var key in sortedKeys) {
                if (AlibabaCloud.DarabonbaString.StringUtil.HasPrefix(key, prefix))
                {
                    canonicalizedHeaders = "" + canonicalizedHeaders + key + ":" + AlibabaCloud.DarabonbaString.StringUtil.Trim(headers.Get(key)) + "\n";
                }
            }
            return canonicalizedHeaders;
        }

        public static string GetCanonicalizedResource(string pathname, Dictionary<string, string> query)
        {
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(pathname))
            {
                return "/";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(query))
            {
                return pathname;
            }
            string canonicalizedResource = "";
            List<string> queryArray = AlibabaCloud.DarabonbaMap.MapUtil.KeySet(query);
            List<string> sortedQueryArray = AlibabaCloud.DarabonbaArray.ArrayUtil.AscSort(queryArray);
            string separator = "";
            canonicalizedResource = "" + pathname + "?";

            foreach (var key in sortedQueryArray) {
                canonicalizedResource = "" + canonicalizedResource + separator + key;
                if (!AlibabaCloud.TeaUtil.Common.Empty(query.Get(key)))
                {
                    canonicalizedResource = "" + canonicalizedResource + "=" + query.Get(key);
                }
                separator = "&";
            }
            return canonicalizedResource;
        }

        public static string GetCaCertFromContent(byte[] reqBody)
        {
            return AlibabaCloud.TeaUtil.Common.ToString(reqBody);
        }

        public static string GetCaCertFromFile(string reqBody)
        {
            string caCerts = AlibabaCloud.TeaUtil.Common.ReadAsString(AlibabaCloud.DarabonbaStream.StreamUtil.ReadFromFilePath(reqBody));
            int? length = caCerts.Length;
            long? endIndex = AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(AlibabaCloud.DarabonbaString.StringUtil.Index(caCerts, "-----END CERTIFICATE-----"));
            long? suffixLength = AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(25);
            int? subCaStart = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(endIndex, suffixLength));
            string rootCa = AlibabaCloud.DarabonbaString.StringUtil.SubString(caCerts, 0, subCaStart);
            string subCa = AlibabaCloud.DarabonbaString.StringUtil.SubString(caCerts, subCaStart, length);
            if (AlibabaCloud.TeaUtil.Common.Empty(AlibabaCloud.DarabonbaString.StringUtil.Trim(subCa)))
            {
                return rootCa;
            }
            return subCa;
        }

        public static byte[] GetSerializedEncryptRequest(Dictionary<string, object> reqBody)
        {
            using (MemoryStream output = new MemoryStream())
            {
                EncryptRequest request = new EncryptRequest();
                object keyId = reqBody["KeyId"];
                if (keyId != null) 
                {
                    request.KeyId = keyId.ToString();
                }
                object plaintext = reqBody["Plaintext"];
                if (plaintext != null) 
                {
                    request.Plaintext = ByteString.CopyFrom((byte[])plaintext);
                }
                object algorithm = reqBody["Algorithm"];
                if (algorithm != null) 
                {
                    request.Algorithm = algorithm.ToString();
                }
                object aad = reqBody["Aad"];
                if (aad != null) 
                {
                    request.Aad = ByteString.CopyFrom((byte[])aad);
                }
                object iv = reqBody["Iv"];
                if (iv != null) 
                {
                    request.Iv = ByteString.CopyFrom((byte[])iv);
                }
                object paddingMode = reqBody["PaddingMode"];
                if (paddingMode != null) 
                {
                    request.PaddingMode = paddingMode.ToString();
                }
                request.WriteTo(output);
                return output.ToArray();
            }
            
        }

        public static Dictionary<string, object> ParseEncryptResponse(byte[] resBody)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            EncryptResponse response =  EncryptResponse.Parser.ParseFrom(resBody);
            result.Add("KeyId",response.KeyId);
            result.Add("CiphertextBlob",response.CiphertextBlob.ToByteArray());
            result.Add("Iv",response.Iv.ToByteArray());
            result.Add("RequestId",response.RequestId);
            result.Add("Algorithm",response.Algorithm);
            result.Add("PaddingMode",response.PaddingMode);
            return result;            
        }

        public static string GetPrivatePemFromPk12(byte[] privateKeyData, string password)
        {
            X509Certificate2 cert = new X509Certificate2(privateKeyData, password, X509KeyStorageFlags.Exportable);
            RSA rsa = cert.GetRSAPrivateKey();
            return rsa.ToXmlString(true);            
        }

        public static byte[] GetSerializedDecryptRequest(Dictionary<string, object> reqBody)
        {
            using (MemoryStream output = new MemoryStream())
            {
                DecryptRequest request = new DecryptRequest();
                object ciphertextBlob = reqBody["CiphertextBlob"];
                if (ciphertextBlob != null) 
                {
                    request.CiphertextBlob = ByteString.CopyFrom((byte[])ciphertextBlob);
                }
                object keyId = reqBody["KeyId"];
                if (keyId != null) 
                {
                    request.KeyId = keyId.ToString();
                }
                object algorithm = reqBody["Algorithm"];
                if (algorithm != null) 
                {
                    request.Algorithm = algorithm.ToString();
                }
                object aad = reqBody["Aad"];
                if (aad != null) 
                {
                    request.Aad = ByteString.CopyFrom((byte[])aad);
                }
                object iv = reqBody["Iv"];
                if (iv != null) 
                {
                    request.Iv = ByteString.CopyFrom((byte[])iv);
                }
                object paddingMode = reqBody["PaddingMode"];
                if (paddingMode != null) 
                {
                    request.PaddingMode = paddingMode.ToString();
                }
                request.WriteTo(output);
                return output.ToArray();
            }
            
        }

        public static Dictionary<string, object> ParseDecryptResponse(byte[] resBody)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            DecryptResponse response =  DecryptResponse.Parser.ParseFrom(resBody);
            result.Add("KeyId",response.KeyId);
            result.Add("Plaintext",response.Plaintext.ToByteArray());
            result.Add("RequestId",response.RequestId);
            result.Add("Algorithm",response.Algorithm);
            result.Add("PaddingMode",response.PaddingMode);
            return result;            
        }

        public static byte[] GetSerializedSignRequest(Dictionary<string, object> reqBody)
        {
            using (MemoryStream output = new MemoryStream())
            {
                SignRequest request = new SignRequest();
                object keyId = reqBody["KeyId"];
                if (keyId != null) 
                {
                    request.KeyId = keyId.ToString();
                }
                object digest = reqBody["Digest"];
                if (digest != null) 
                {
                    request.Digest = ByteString.CopyFrom((byte[])digest);
                }
                object algorithm = reqBody["Algorithm"];
                if (algorithm != null) 
                {
                    request.Algorithm = algorithm.ToString();
                }
                object message = reqBody["Message"];
                if (message != null) 
                {
                    request.Message = ByteString.CopyFrom((byte[])message);
                }
                object messageType = reqBody["MessageType"];
                if (messageType != null) 
                {
                    request.MessageType = messageType.ToString();
                }
                request.WriteTo(output);
                return output.ToArray();
            }
            
        }

        public static Dictionary<string, object> ParseSignResponse(byte[] resBody)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            SignResponse response =  SignResponse.Parser.ParseFrom(resBody);
            result.Add("KeyId",response.KeyId);
            result.Add("Signature",response.Signature.ToByteArray());
            result.Add("RequestId",response.RequestId);
            result.Add("Algorithm",response.Algorithm);
            result.Add("MessageType",response.MessageType);
            return result;            
        }

        public static byte[] GetSerializedVerifyRequest(Dictionary<string, object> reqBody)
        {
            using (MemoryStream output = new MemoryStream())
            {
                VerifyRequest request = new VerifyRequest();
                object keyId = reqBody["KeyId"];
                if (keyId != null) 
                {
                    request.KeyId = keyId.ToString();
                }
                object digest = reqBody["Digest"];
                if (digest != null) 
                {
                    request.Digest = ByteString.CopyFrom((byte[])digest);
                }
                object signature = reqBody["Signature"];
                if (signature != null) 
                {
                    request.Signature = ByteString.CopyFrom((byte[])signature);
                }
                object algorithm = reqBody["Algorithm"];
                if (algorithm != null) 
                {
                    request.Algorithm = algorithm.ToString();
                }
                object message = reqBody["Message"];
                if (message != null) 
                {
                    request.Message = ByteString.CopyFrom((byte[])message);
                }
                object messageType = reqBody["MessageType"];
                if (messageType != null) 
                {
                    request.MessageType = messageType.ToString();
                }
                request.WriteTo(output);
                return output.ToArray();
            }
            
        }

        public static Dictionary<string, object> ParseVerifyResponse(byte[] resBody)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            VerifyResponse response =  VerifyResponse.Parser.ParseFrom(resBody);
            result.Add("KeyId",response.KeyId);
            result.Add("Value",response.Value);
            result.Add("RequestId",response.RequestId);
            result.Add("Algorithm",response.Algorithm);
            result.Add("MessageType",response.MessageType);
            return result;            
        }

        public static byte[] GetSerializedHmacRequest(Dictionary<string, object> reqBody)
        {
            using (MemoryStream output = new MemoryStream())
            {
                HmacRequest request = new HmacRequest();
                object keyId = reqBody["KeyId"];
                if (keyId != null) 
                {
                    request.KeyId = keyId.ToString();
                }
                object message = reqBody["Message"];
                if (message != null) 
                {
                    request.Message = ByteString.CopyFrom((byte[])message);
                }
                request.WriteTo(output);
                return output.ToArray();
            }
            
        }

        public static Dictionary<string, object> ParseHmacResponse(byte[] resBody)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            HmacResponse response =  HmacResponse.Parser.ParseFrom(resBody);
            result.Add("KeyId",response.KeyId);
            result.Add("Signature",response.Signature.ToByteArray());
            result.Add("RequestId",response.RequestId);
            return result;            
        }

        public static byte[] GetSerializedGenerateRandomRequest(Dictionary<string, object> reqBody)
        {
            using (MemoryStream output = new MemoryStream())
            {
                GenerateRandomRequest request = new GenerateRandomRequest();
                object length = reqBody["Length"];
                if (length != null) 
                {
                    request.Length = (int)length;
                }
                request.WriteTo(output);
                return output.ToArray();
            }
            
        }

        public static Dictionary<string, object> ParseGenerateRandomResponse(byte[] resBody)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            GenerateRandomResponse response =  GenerateRandomResponse.Parser.ParseFrom(resBody);
            result.Add("Random",response.Random.ToByteArray());
            result.Add("RequestId",response.RequestId);
            return result;            
        }

        public static byte[] GetSerializedGenerateDataKeyRequest(Dictionary<string, object> reqBody)
        {
            using (MemoryStream output = new MemoryStream())
            {
                GenerateDataKeyRequest request = new GenerateDataKeyRequest();
                object keyId = reqBody["KeyId"];
                if (keyId != null) 
                {
                    request.KeyId = keyId.ToString();
                }
                object algorithm = reqBody["Algorithm"];
                if (algorithm != null) 
                {
                    request.Algorithm = algorithm.ToString();
                }
                object numberOfBytes = reqBody["NumberOfBytes"];
                if (numberOfBytes != null) 
                {
                    request.NumberOfBytes = (int)numberOfBytes;
                }
                object aad = reqBody["Aad"];
                if (aad != null) 
                {
                    request.Aad = ByteString.CopyFrom((byte[])aad);
                }
                request.WriteTo(output);
                return output.ToArray();
            }
            
        }

        public static Dictionary<string, object> ParseGenerateDataKeyResponse(byte[] resBody)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            GenerateDataKeyResponse response =  GenerateDataKeyResponse.Parser.ParseFrom(resBody);
            result.Add("KeyId",response.KeyId);
            result.Add("Iv",response.Iv.ToByteArray());
            result.Add("Plaintext",response.Plaintext.ToByteArray());
            result.Add("CiphertextBlob",response.CiphertextBlob.ToByteArray());
            result.Add("RequestId",response.RequestId);
            result.Add("Algorithm",response.Algorithm);
            return result;            
        }

        public static byte[] GetSerializedGetPublicKeyRequest(Dictionary<string, object> reqBody)
        {
            using (MemoryStream output = new MemoryStream())
            {
                GetPublicKeyRequest request = new GetPublicKeyRequest();
                object keyId = reqBody["KeyId"];
                if (keyId != null) 
                {
                    request.KeyId = keyId.ToString();
                }
                request.WriteTo(output);
                return output.ToArray();
            }
            
        }

        public static Dictionary<string, object> ParseGetPublicKeyResponse(byte[] resBody)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            GetPublicKeyResponse response =  GetPublicKeyResponse.Parser.ParseFrom(resBody);
            result.Add("KeyId",response.KeyId);
            result.Add("PublicKey",response.PublicKey);
            result.Add("RequestId",response.RequestId);
            return result;            
        }

        public static byte[] GetSerializedGetSecretValueRequest(Dictionary<string, object> reqBody)
        {
            using (MemoryStream output = new MemoryStream())
            {
                GetSecretValueRequest request = new GetSecretValueRequest();
                object secretName = reqBody["SecretName"];
                if (secretName != null) 
                {
                    request.SecretName = secretName.ToString();
                }
                object versionStage = reqBody["VersionStage"];
                if (versionStage != null) 
                {
                    request.VersionStage = versionStage.ToString();
                }
                object versionId = reqBody["VersionId"];
                if (versionId != null) 
                {
                    request.VersionId = versionId.ToString();
                }
                object fetchExtendedConfig = reqBody["FetchExtendedConfig"];
                if (fetchExtendedConfig != null) 
                {
                    request.FetchExtendedConfig = (bool)fetchExtendedConfig;
                }
                request.WriteTo(output);
                return output.ToArray();
            }
            
        }

        public static Dictionary<string, object> ParseGetSecretValueResponse(byte[] resBody)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            GetSecretValueResponse response =  GetSecretValueResponse.Parser.ParseFrom(resBody);
            result.Add("SecretName",response.SecretName);
            result.Add("SecretType",response.SecretType);
            result.Add("SecretData",response.SecretData);
            result.Add("SecretDataType",response.SecretDataType);
            result.Add("VersionStages",response.VersionStages);
            result.Add("VersionId",response.VersionId);
            result.Add("CreateTime",response.CreateTime);
            result.Add("RequestId",response.RequestId);
            result.Add("LastRotationDate",response.LastRotationDate);
            result.Add("NextRotationDate",response.NextRotationDate);
            result.Add("ExtendedConfig",response.ExtendedConfig);
            result.Add("AutomaticRotation",response.AutomaticRotation);
            result.Add("RotationInterval",response.RotationInterval);
            return result;            
        }

    }
}
