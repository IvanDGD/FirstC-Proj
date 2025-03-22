using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.GenericCollections
{
    internal class Visit
    {
        public string ClientName { get; set; }
        public DateTime VisitDate { get; set; }

        public Visit(string clientName, DateTime visitDate)
        {
            ClientName = clientName;
            VisitDate = visitDate;
        }

        public override string ToString()
        {
            return $"{ClientName} visited on {VisitDate}";
        }
    }
}
