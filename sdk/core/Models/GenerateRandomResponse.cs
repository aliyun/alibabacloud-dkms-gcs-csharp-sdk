// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.Dkms.Gcs.Sdk.Models
{
    public class GenerateRandomResponse : TeaModel {
        [NameInMap("Random")]
        [Validation(Required=false)]
        public byte[] Random { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("responseHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> ResponseHeaders { get; set; }

    }

}
