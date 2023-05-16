// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.Dkms.Gcs.Sdk.Models
{
    public class SignRequest : TeaModel {
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        [NameInMap("Digest")]
        [Validation(Required=false)]
        public byte[] Digest { get; set; }

        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public byte[] Message { get; set; }

        [NameInMap("MessageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        [NameInMap("requestHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> RequestHeaders { get; set; }

    }

}
