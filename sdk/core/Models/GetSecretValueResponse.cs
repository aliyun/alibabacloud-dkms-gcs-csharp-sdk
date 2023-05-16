// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.Dkms.Gcs.Sdk.Models
{
    public class GetSecretValueResponse : TeaModel {
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        [NameInMap("SecretType")]
        [Validation(Required=false)]
        public string SecretType { get; set; }

        [NameInMap("SecretData")]
        [Validation(Required=false)]
        public string SecretData { get; set; }

        [NameInMap("SecretDataType")]
        [Validation(Required=false)]
        public string SecretDataType { get; set; }

        [NameInMap("VersionStages")]
        [Validation(Required=false)]
        public List<string> VersionStages { get; set; }

        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LastRotationDate")]
        [Validation(Required=false)]
        public string LastRotationDate { get; set; }

        [NameInMap("NextRotationDate")]
        [Validation(Required=false)]
        public string NextRotationDate { get; set; }

        [NameInMap("ExtendedConfig")]
        [Validation(Required=false)]
        public string ExtendedConfig { get; set; }

        [NameInMap("AutomaticRotation")]
        [Validation(Required=false)]
        public string AutomaticRotation { get; set; }

        [NameInMap("RotationInterval")]
        [Validation(Required=false)]
        public string RotationInterval { get; set; }

        [NameInMap("responseHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> ResponseHeaders { get; set; }

    }

}
