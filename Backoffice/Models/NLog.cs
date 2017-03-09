using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Backoffice.Models
{
    public class NLogs
    {
        public int ID { get; set; }
        [MaxLength(200)]
        public string MachineName { get; set; }
        [MaxLength(200)]
        public string SiteName { get; set; }
        public DateTime Logged { get; set; }
        [MaxLength(5)]
        public string Level { get; set; }
        [MaxLength(200)]
        public string UserName { get; set; }
        public string Message { get; set; }
        [MaxLength(300)]
        public string Logger { get; set; }
        public string Properties { get; set; }
        [MaxLength(200)]
        public string ServerName { get; set; }
        [MaxLength(100)]
        public string Port { get; set; }
        [MaxLength(2000)]
        public string Url { get; set; }
        public byte Https { get; set; }
        [MaxLength(100)]
        public string ServerAddress { get; set; }
        [MaxLength(100)]
        public string RemoteAddress { get; set; }
        [MaxLength(300)]
        public string Callsite { get; set; }
        public string Exception { get; set; }

    }
}