// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.Dkms.Gcs.OpenApi.Models
{
    public class Config : TeaModel {
        [NameInMap("accessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// pkcs1 or pkcs8 PEM format private key
        /// </summary>
        [NameInMap("privateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// crypto service address
        /// </summary>
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("regionId")]
        [Validation(Required=false, Pattern="[a-zA-Z0-9-_]+")]
        public string RegionId { get; set; }

        [NameInMap("readTimeout")]
        [Validation(Required=false)]
        public int? ReadTimeout { get; set; }

        [NameInMap("connectTimeout")]
        [Validation(Required=false)]
        public int? ConnectTimeout { get; set; }

        [NameInMap("httpProxy")]
        [Validation(Required=false)]
        public string HttpProxy { get; set; }

        [NameInMap("httpsProxy")]
        [Validation(Required=false)]
        public string HttpsProxy { get; set; }

        [NameInMap("socks5Proxy")]
        [Validation(Required=false)]
        public string Socks5Proxy { get; set; }

        [NameInMap("socks5NetWork")]
        [Validation(Required=false)]
        public string Socks5NetWork { get; set; }

        [NameInMap("noProxy")]
        [Validation(Required=false)]
        public string NoProxy { get; set; }

        [NameInMap("maxIdleConns")]
        [Validation(Required=false)]
        public int? MaxIdleConns { get; set; }

        [NameInMap("userAgent")]
        [Validation(Required=false)]
        public string UserAgent { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("credential")]
        [Validation(Required=false)]
        public AlibabaCloud.Dkms.Gcs.OpenApiCredential.Client Credential { get; set; }

        [NameInMap("clientKeyFile")]
        [Validation(Required=false)]
        public string ClientKeyFile { get; set; }

        /// <summary>
        /// client key content
        /// </summary>
        [NameInMap("clientKeyContent")]
        [Validation(Required=false)]
        public string ClientKeyContent { get; set; }

        /// <summary>
        /// password
        /// </summary>
        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// ca
        /// </summary>
        [NameInMap("ca")]
        [Validation(Required=false)]
        public string Ca { get; set; }

        /// <summary>
        /// caFilePath
        /// </summary>
        [NameInMap("caFilePath")]
        [Validation(Required=false)]
        public string CaFilePath { get; set; }

        /// <summary>
        /// ignoreSSL
        /// </summary>
        [NameInMap("ignoreSSL")]
        [Validation(Required=false)]
        public bool? IgnoreSSL { get; set; }

    }

}
