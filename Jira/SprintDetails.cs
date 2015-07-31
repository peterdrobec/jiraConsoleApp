using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jira
{
        public class SprintDetails
    {
        public int id { get; set; }
        public int sequence { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public int linkedPagesCount { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string completeDate { get; set; }
        public List<object> remoteLinks { get; set; }
        public int daysRemaining { get; set; }
    }
}
