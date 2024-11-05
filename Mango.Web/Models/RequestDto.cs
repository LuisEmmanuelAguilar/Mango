﻿using static Mango.Web.Utility.StandardDetails;

namespace Mango.Web.Models
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
        public ContentType ContentType { get; set; } = ContentType.Json;
    }
}
