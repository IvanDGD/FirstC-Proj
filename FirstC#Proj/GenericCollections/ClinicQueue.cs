using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.GenericCollections
{
    internal class ClinicQueue
    {
        private PriorityQueue<Patient, int> queue = new PriorityQueue<Patient, int>();
        private int maxQueueSize;

        public ClinicQueue(int maxQueueSize)
        {
            this.maxQueueSize = maxQueueSize;
        }

        public void AddPatient(string name, int severity)
        {
            if (queue.Count >= maxQueueSize)
            {
                Console.WriteLine($"Queue is full! {name} is waiting.");
            }
            else
            {
                queue.Enqueue(new Patient(name, severity), -severity);
                Console.WriteLine($"Patient {name} added to the queue.");
            }
        }

        public void ProcessPatient()
        {
            if (queue.Count > 0)
            {
                var patient = queue.Dequeue();
                Console.WriteLine($"Doctor is seeing patient: {patient.Name}");
            }
            else
            {
                Console.WriteLine("No patients in queue.");
            }
        }

        public void DisplayQueue()
        {
            Console.WriteLine("\nCurrent Queue:");
            foreach (var patient in queue.UnorderedItems)
            {
                Console.WriteLine(patient.Element);
            }
        }
    }
}
