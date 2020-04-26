using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arch.API
{
    public class AppSettings
    {
        public ConnectionStrings ConnectionStrings { get; set; }
    }

    public class ConnectionStrings
    {
        public string SQL { get; set; }
        public string Mongo { get; set; }
        public string ElasticSearch { get; set; }
        public string Redis { get; set; }
    }
}
