// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.Dkms.Gcs.OpenApiCredential.Models
{
    public class Config : TeaModel {
        [NameInMap("type")]
        [Validation(Required=true)]
        public string Type { get; set; }

        [NameInMap("accessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        [NameInMap("privateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        [NameInMap("clientKeyFile")]
        [Validation(Required=false)]
        public string ClientKeyFile { get; set; }

        [NameInMap("clientKeyContent")]
        [Validation(Required=false)]
        public string ClientKeyContent { get; set; }

        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

    }

}
