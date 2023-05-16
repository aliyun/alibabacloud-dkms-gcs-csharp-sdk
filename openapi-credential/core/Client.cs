// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.Dkms.Gcs.OpenApiCredential.Models;

namespace AlibabaCloud.Dkms.Gcs.OpenApiCredential
{
    public class Client 
    {
        protected string _keyId;
        protected string _privateKeySecret;

        public Client(Config config)
        {
            if (AlibabaCloud.TeaUtil.Common.EqualString("rsa_key_pair", config.Type))
            {
                if (!AlibabaCloud.TeaUtil.Common.Empty(config.ClientKeyContent))
                {
                    object json = AlibabaCloud.TeaUtil.Common.ParseJSON(config.ClientKeyContent);
                    Dictionary<string, object> clientKey = AlibabaCloud.TeaUtil.Common.AssertAsMap(json);
                    byte[] privateKeyData = AlibabaCloud.DarabonbaEncodeUtil.Encoder.Base64Decode(AlibabaCloud.TeaUtil.Common.AssertAsString(clientKey.Get("PrivateKeyData")));
                    this._privateKeySecret = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetPrivatePemFromPk12(privateKeyData, config.Password);
                    this._keyId = AlibabaCloud.TeaUtil.Common.AssertAsString(clientKey.Get("KeyId"));
                }
                else if (!AlibabaCloud.TeaUtil.Common.Empty(config.ClientKeyFile))
                {
                    object jsonFromFile = AlibabaCloud.TeaUtil.Common.ReadAsJSON(AlibabaCloud.DarabonbaStream.StreamUtil.ReadFromFilePath(config.ClientKeyFile));
                    if (AlibabaCloud.TeaUtil.Common.IsUnset(jsonFromFile))
                    {
                        throw new TeaException(new Dictionary<string, string>
                        {
                            {"message", "read client key file failed: " + config.ClientKeyFile},
                        });
                    }
                    Dictionary<string, object> clientKeyFromFile = AlibabaCloud.TeaUtil.Common.AssertAsMap(jsonFromFile);
                    byte[] privateKeyDataFromFile = AlibabaCloud.DarabonbaEncodeUtil.Encoder.Base64Decode(AlibabaCloud.TeaUtil.Common.AssertAsString(clientKeyFromFile.Get("PrivateKeyData")));
                    this._privateKeySecret = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetPrivatePemFromPk12(privateKeyDataFromFile, config.Password);
                    this._keyId = AlibabaCloud.TeaUtil.Common.AssertAsString(clientKeyFromFile.Get("KeyId"));
                }
                else
                {
                    this._privateKeySecret = config.PrivateKey;
                    this._keyId = config.AccessKeyId;
                }
            }
            else
            {
                throw new TeaException(new Dictionary<string, string>
                {
                    {"message", "Only support rsa key pair credential provider now."},
                });
            }
        }


        public string GetAccessKeyId()
        {
            return _keyId;
        }

        public string GetAccessKeySecret()
        {
            return _privateKeySecret;
        }

        public string GetSignature(string strToSign)
        {
            string prefix = "Bearer ";
            string sign = AlibabaCloud.DarabonbaEncodeUtil.Encoder.Base64EncodeToString(AlibabaCloud.DarabonbaSignatureUtil.Signer.SHA256withRSASign(strToSign, GetAccessKeySecret()));
            return "" + prefix + sign;
        }

    }
}
