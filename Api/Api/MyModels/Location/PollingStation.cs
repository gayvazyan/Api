using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.MyModels
{
    public class PollingStation
    {
        public int Id { get; set; }
        public int? Constituency { get; set; }
        public string Name { get; set; }
        public string Community { get; set; }
        public string Region { get; set; }
        public string Address { get; set; }
        public int? Voters_count { get; set; }
    }
}
