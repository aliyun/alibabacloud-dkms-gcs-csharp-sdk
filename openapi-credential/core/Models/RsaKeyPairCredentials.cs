// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.Dkms.Gcs.OpenApiCredential.Models
{
    public class RsaKeyPairCredentials : TeaModel {
        [NameInMap("privateKeySecret")]
        [Validation(Required=false)]
        public string PrivateKeySecret { get; set; }

        [NameInMap("keyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

    }

}
