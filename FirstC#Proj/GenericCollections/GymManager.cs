using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.GenericCollections
{
    internal class GymManager
    {
        private Dictionary<string, Stack<Visit>> visitHistory = new Dictionary<string, Stack<Visit>>();

        public void AddVisit(string clientName)
        {
            if (!visitHistory.ContainsKey(clientName))
            {
                visitHistory[clientName] = new Stack<Visit>();
            }

            var visit = new Visit(clientName, DateTime.Now);
            visitHistory[clientName].Push(visit);

            Console.WriteLine($"Visit added: {clientName} at {visit.VisitDate}");
        }

        public void CancelLastVisit(string clientName)
        {
            if (visitHistory.ContainsKey(clientName) && visitHistory[clientName].Count > 0)
            {
                var canceledVisit = visitHistory[clientName].Pop();
                Console.WriteLine($"Canceled last visit: {canceledVisit}");
            }
            else
            {
                Console.WriteLine($"No visits found for {clientName}.");
            }
        }

        public void ShowLastVisits(string clientName, int count)
        {
            if (visitHistory.ContainsKey(clientName) && visitHistory[clientName].Count > 0)
            {
                Console.WriteLine($"\nLast {count} visits for {clientName}:");
                foreach (var visit in visitHistory[clientName])
                {
                    Console.WriteLine(visit);
                    if (--count == 0) break;
                }
            }
            else
            {
                Console.WriteLine($"No visits found for {clientName}.");
            }
        }

        public void ShowVisitsInPeriod(DateTime startDate, DateTime endDate)
        {
            Console.WriteLine($"\nVisits from {startDate} to {endDate}:");
            foreach (var client in visitHistory)
            {
                foreach (var visit in client.Value)
                {
                    if (visit.VisitDate >= startDate && visit.VisitDate <= endDate)
                    {
                        Console.WriteLine(visit);
                    }
                }
            }
        }
    }
}
