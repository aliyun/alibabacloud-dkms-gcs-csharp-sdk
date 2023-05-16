// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.Dkms.Gcs.Sdk.Models
{
    public class GetPublicKeyRequest : TeaModel {
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        [NameInMap("requestHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> RequestHeaders { get; set; }

    }

}
