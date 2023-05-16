// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.Dkms.Gcs.Sdk.Models
{
    public class HmacResponse : TeaModel {
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        [NameInMap("Signature")]
        [Validation(Required=false)]
        public byte[] Signature { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("responseHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> ResponseHeaders { get; set; }

    }

}
