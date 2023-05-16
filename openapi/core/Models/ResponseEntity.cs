// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.Dkms.Gcs.OpenApi.Models
{
    public class ResponseEntity : TeaModel {
        [NameInMap("bodyBytes")]
        [Validation(Required=false)]
        public byte[] BodyBytes { get; set; }

        [NameInMap("responseHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> ResponseHeaders { get; set; }

    }

}
