// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.Dkms.Gcs.Sdk.Models
{
    public class GenerateDataKeyRequest : TeaModel {
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        [NameInMap("NumberOfBytes")]
        [Validation(Required=false)]
        public int? NumberOfBytes { get; set; }

        [NameInMap("Aad")]
        [Validation(Required=false)]
        public byte[] Aad { get; set; }

        [NameInMap("requestHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> RequestHeaders { get; set; }

    }

}
