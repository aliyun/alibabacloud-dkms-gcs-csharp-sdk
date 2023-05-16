// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.Dkms.Gcs.OpenApi.Models;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Linq;

namespace AlibabaCloud.Dkms.Gcs.OpenApi
{
    public class Client 
    {
        protected string _endpoint;
        protected string _regionId;
        protected string _protocol;
        protected int? _readTimeout;
        protected int? _connectTimeout;
        protected string _httpProxy;
        protected string _httpsProxy;
        protected string _noProxy;
        protected string _userAgent;
        protected string _socks5Proxy;
        protected string _socks5NetWork;
        protected int? _maxIdleConns;
        protected AlibabaCloud.Dkms.Gcs.OpenApiCredential.Client _credential;
        protected string _ca;
        protected bool? _ignoreSSL;

        public Client(Config config)
        {
            if (AlibabaCloud.TeaUtil.Common.IsUnset(config))
            {
                throw new TeaException(new Dictionary<string, string>
                {
                    {"name", "ParameterMissing"},
                    {"message", "'config' can not be unset"},
                });
            }
            if (AlibabaCloud.TeaUtil.Common.Empty(config.Endpoint))
            {
                throw new TeaException(new Dictionary<string, string>
                {
                    {"code", "ParameterMissing"},
                    {"message", "'config.endpoint' can not be empty"},
                });
            }
            if (!AlibabaCloud.TeaUtil.Common.Empty(config.ClientKeyContent))
            {
                config.Type = "rsa_key_pair";
                AlibabaCloud.Dkms.Gcs.OpenApiCredential.Models.Config contentConfig = new AlibabaCloud.Dkms.Gcs.OpenApiCredential.Models.Config
                {
                    Type = config.Type,
                    ClientKeyContent = config.ClientKeyContent,
                    Password = config.Password,
                };
                this._credential = new AlibabaCloud.Dkms.Gcs.OpenApiCredential.Client(contentConfig);
            }
            else if (!AlibabaCloud.TeaUtil.Common.Empty(config.ClientKeyFile))
            {
                config.Type = "rsa_key_pair";
                AlibabaCloud.Dkms.Gcs.OpenApiCredential.Models.Config clientKeyConfig = new AlibabaCloud.Dkms.Gcs.OpenApiCredential.Models.Config
                {
                    Type = config.Type,
                    ClientKeyFile = config.ClientKeyFile,
                    Password = config.Password,
                };
                this._credential = new AlibabaCloud.Dkms.Gcs.OpenApiCredential.Client(clientKeyConfig);
            }
            else if (!AlibabaCloud.TeaUtil.Common.Empty(config.AccessKeyId) && !AlibabaCloud.TeaUtil.Common.Empty(config.PrivateKey))
            {
                config.Type = "rsa_key_pair";
                AlibabaCloud.Dkms.Gcs.OpenApiCredential.Models.Config credentialConfig = new AlibabaCloud.Dkms.Gcs.OpenApiCredential.Models.Config
                {
                    Type = config.Type,
                    AccessKeyId = config.AccessKeyId,
                    PrivateKey = config.PrivateKey,
                };
                this._credential = new AlibabaCloud.Dkms.Gcs.OpenApiCredential.Client(credentialConfig);
            }
            else if (!AlibabaCloud.TeaUtil.Common.IsUnset(config.Credential))
            {
                this._credential = config.Credential;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(config.Ca))
            {
                this._ca = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetCaCertFromContent(AlibabaCloud.TeaUtil.Common.ToBytes(config.Ca));
            }
            else
            {
                if (!AlibabaCloud.TeaUtil.Common.IsUnset(config.CaFilePath))
                {
                    this._ca = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetCaCertFromFile(config.CaFilePath);
                }
            }
            this._endpoint = config.Endpoint;
            this._protocol = config.Protocol;
            this._regionId = config.RegionId;
            this._userAgent = config.UserAgent;
            this._readTimeout = config.ReadTimeout;
            this._connectTimeout = config.ConnectTimeout;
            this._httpProxy = config.HttpProxy;
            this._httpsProxy = config.HttpsProxy;
            this._noProxy = config.NoProxy;
            this._socks5Proxy = config.Socks5Proxy;
            this._socks5NetWork = config.Socks5NetWork;
            this._maxIdleConns = config.MaxIdleConns;
            this._ignoreSSL = config.IgnoreSSL;
        }

        public Dictionary<string, object> DoRequest(string apiName, string apiVersion, string protocol, string method, string signatureMethod, byte[] reqBodyBytes, AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime, Dictionary<string, string> requestHeaders)
        {
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"ca", _ca},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, protocol);
                    request_.Method = method;
                    request_.Pathname = "/";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        requestHeaders
                    );
                    request_.Headers["accept"] = "application/x-protobuf";
                    request_.Headers["host"] = _endpoint;
                    request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                    request_.Headers["user-agent"] = AlibabaCloud.TeaUtil.Common.GetUserAgent(_userAgent);
                    request_.Headers["x-kms-apiversion"] = apiVersion;
                    request_.Headers["x-kms-apiname"] = apiName;
                    request_.Headers["x-kms-signaturemethod"] = signatureMethod;
                    request_.Headers["x-kms-acccesskeyid"] = this._credential.GetAccessKeyId();
                    request_.Headers["content-type"] = "application/x-protobuf";
                    request_.Headers["content-length"] = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetContentLength(reqBodyBytes);
                    request_.Headers["content-sha256"] = AlibabaCloud.DarabonbaString.StringUtil.ToUpper(AlibabaCloud.OpenApiUtil.Client.HexEncode(AlibabaCloud.OpenApiUtil.Client.Hash(reqBodyBytes, "ACS3-RSA-SHA256")));
                    request_.Body = TeaCore.BytesReadable(reqBodyBytes);
                    string strToSign = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetStringToSign(method, request_.Pathname, request_.Headers, request_.Query);
                    request_.Headers["authorization"] = this._credential.GetSignature(strToSign);
                    _lastRequest = request_;
                    if(HttpClientUtils.ServerCertificateCustomValidationCallback == null)
                    {
                        HttpClientUtils.ServerCertificateCustomValidationCallback = CertificateValidationCallBack;
                    }

                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    byte[] bodyBytes = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyBytes = AlibabaCloud.TeaUtil.Common.ReadAsBytes(response_.Body);
                        Dictionary<string, object> respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetErrMessage(bodyBytes));
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyBytes = AlibabaCloud.TeaUtil.Common.ReadAsBytes(response_.Body);
                    Dictionary<string, string> responseHeaders = null;
                    Dictionary<string, string> headers = response_.Headers;
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(runtime.ResponseHeaders))
                    {

                        foreach (var key in AlibabaCloud.DarabonbaMap.MapUtil.KeySet(headers)) {
                            if (AlibabaCloud.DarabonbaArray.ArrayUtil.Contains(runtime.ResponseHeaders, key))
                            {
                                if (AlibabaCloud.TeaUtil.Common.IsUnset(responseHeaders))
                                {
                                    responseHeaders = new Dictionary<string, string>(){};
                                }
                                responseHeaders[key] = headers.Get(key);
                            }
                        }
                    }
                    return new Dictionary<string, object>
                    {
                        {"bodyBytes", bodyBytes},
                        {"responseHeaders", responseHeaders},
                    };
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public static bool CertificateValidationCallBack(object sender, X509Certificate2Collection caCerts, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            if (sslPolicyErrors == SslPolicyErrors.None)
            {
                return true;
            }

            if ((sslPolicyErrors & SslPolicyErrors.RemoteCertificateChainErrors) != 0)
            {
                chain.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;
                chain.ChainPolicy.ExtraStore.AddRange(caCerts);
                chain.ChainPolicy.VerificationFlags = X509VerificationFlags.AllowUnknownCertificateAuthority | X509VerificationFlags.IgnoreInvalidBasicConstraints;
                bool isValid = chain.Build((X509Certificate2)certificate);
                bool isTrust = false;
                X509Certificate2 caRoot = chain.ChainElements[chain.ChainElements.Count - 1].Certificate;
                X509Certificate2Enumerator enumerator = caCerts.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    X509Certificate2 current = enumerator.Current;
                    if (caRoot.RawData.SequenceEqual(current.RawData))
                    {
                        isTrust = true;
                        break;
                    }
                }

                return isValid && isTrust;
            }

            return false;
        }
        public async Task<Dictionary<string, object>> DoRequestAsync(string apiName, string apiVersion, string protocol, string method, string signatureMethod, byte[] reqBodyBytes, AlibabaCloud.Dkms.Gcs.OpenApiUtil.Models.RuntimeOptions runtime, Dictionary<string, string> requestHeaders)
        {
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
                {"ca", _ca},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, protocol);
                    request_.Method = method;
                    request_.Pathname = "/";
                    request_.Headers = TeaConverter.merge<string>
                    (
                        requestHeaders
                    );
                    request_.Headers["accept"] = "application/x-protobuf";
                    request_.Headers["host"] = _endpoint;
                    request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                    request_.Headers["user-agent"] = AlibabaCloud.TeaUtil.Common.GetUserAgent(_userAgent);
                    request_.Headers["x-kms-apiversion"] = apiVersion;
                    request_.Headers["x-kms-apiname"] = apiName;
                    request_.Headers["x-kms-signaturemethod"] = signatureMethod;
                    request_.Headers["x-kms-acccesskeyid"] = this._credential.GetAccessKeyId();
                    request_.Headers["content-type"] = "application/x-protobuf";
                    request_.Headers["content-length"] = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetContentLength(reqBodyBytes);
                    request_.Headers["content-sha256"] = AlibabaCloud.DarabonbaString.StringUtil.ToUpper(AlibabaCloud.OpenApiUtil.Client.HexEncode(AlibabaCloud.OpenApiUtil.Client.Hash(reqBodyBytes, "ACS3-RSA-SHA256")));
                    request_.Body = TeaCore.BytesReadable(reqBodyBytes);
                    string strToSign = AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetStringToSign(method, request_.Pathname, request_.Headers, request_.Query);
                    request_.Headers["authorization"] = this._credential.GetSignature(strToSign);
                    _lastRequest = request_;
                    if (HttpClientUtils.ServerCertificateCustomValidationCallback == null)
                    {
                        HttpClientUtils.ServerCertificateCustomValidationCallback = CertificateValidationCallBack;
                    }
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    byte[] bodyBytes = null;
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        bodyBytes = AlibabaCloud.TeaUtil.Common.ReadAsBytes(response_.Body);
                        Dictionary<string, object> respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(AlibabaCloud.Dkms.Gcs.OpenApiUtil.Client.GetErrMessage(bodyBytes));
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", respMap.Get("Code")},
                            {"message", respMap.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", respMap.Get("RequestId")},
                                {"hostId", respMap.Get("HostId")},
                            }},
                        });
                    }
                    bodyBytes = AlibabaCloud.TeaUtil.Common.ReadAsBytes(response_.Body);
                    Dictionary<string, string> responseHeaders = null;
                    Dictionary<string, string> headers = response_.Headers;
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(runtime.ResponseHeaders))
                    {

                        foreach (var key in AlibabaCloud.DarabonbaMap.MapUtil.KeySet(headers)) {
                            if (AlibabaCloud.DarabonbaArray.ArrayUtil.Contains(runtime.ResponseHeaders, key))
                            {
                                if (AlibabaCloud.TeaUtil.Common.IsUnset(responseHeaders))
                                {
                                    responseHeaders = new Dictionary<string, string>(){};
                                }
                                responseHeaders[key] = headers.Get(key);
                            }
                        }
                    }
                    return new Dictionary<string, object>
                    {
                        {"bodyBytes", bodyBytes},
                        {"responseHeaders", responseHeaders},
                    };
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

    }
}
