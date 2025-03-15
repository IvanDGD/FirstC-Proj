using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class ForeignPassport : Passport
    {
        public string ForeignPassportNumber { get; set; }
        public List<string> Visas { get; set; }

        public ForeignPassport(string firstName, string lastName, string nationality, string passportNumber, string dateOfBirth, string foreignPassportNumber)
            : base(firstName, lastName, nationality, passportNumber, dateOfBirth)
        {
            ForeignPassportNumber = foreignPassportNumber;
            Visas = new List<string>();
        }

        public void AddVisa(string visa)
        {
            Visas.Add(visa);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine($"Foreign Passport Number: {ForeignPassportNumber}");
            sb.AppendLine("Visas:");
            if (Visas.Count == 0)
            {
                sb.AppendLine("No visas available.");
            }
            else
            {
                foreach (var visa in Visas)
                {
                    sb.AppendLine(" - " + visa);
                }
            }
            return sb.ToString();
        }
    }
}
