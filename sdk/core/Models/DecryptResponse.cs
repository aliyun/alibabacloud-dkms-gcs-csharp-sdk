// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.Dkms.Gcs.Sdk.Models
{
    public class DecryptResponse : TeaModel {
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        [NameInMap("Plaintext")]
        [Validation(Required=false)]
        public byte[] Plaintext { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        [NameInMap("PaddingMode")]
        [Validation(Required=false)]
        public string PaddingMode { get; set; }

        [NameInMap("responseHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> ResponseHeaders { get; set; }

    }

}
