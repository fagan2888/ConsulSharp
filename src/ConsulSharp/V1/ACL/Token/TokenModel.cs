﻿using Newtonsoft.Json;

namespace ConsulSharp.V1.ACL.Token
{
    public class TokenModel : AbstractToken
    {
        [JsonProperty("CreateTime")]
        public string CreateTime { get; set; }

        [JsonProperty("Hash")]
        public string Hash { get; set; }

        [JsonProperty("CreateIndex")]
        public ulong? CreateIndex { get; set; }

        [JsonProperty("ModifyIndex")]
        public ulong? ModifyIndex { get; set; }
    }
}