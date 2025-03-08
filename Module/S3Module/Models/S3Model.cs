using System;
using System.Collections.Generic;

namespace backend.Module.S3;

public class S3Model
{
    public class Request
    {
        public string? Id { get; set; }
        public string? Url { get; set; }
    }
    public class Response
    {
        public string? Id { get; set; }
        public string? Url { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
    }

}
