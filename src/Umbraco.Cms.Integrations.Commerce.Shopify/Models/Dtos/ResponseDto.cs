﻿using System.Collections.Generic;

using Newtonsoft.Json;

namespace Umbraco.Cms.Integrations.Commerce.Shopify.Models.Dtos
{
    public class ResponseDto<T> 
        where T : class
    {
        [JsonProperty("isValid")]
        public bool IsValid { get; set; }

        [JsonProperty("isExpired")]
        public bool IsExpired { get; set; }

        [JsonProperty("result")] 
        public T Result { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

    }
}
