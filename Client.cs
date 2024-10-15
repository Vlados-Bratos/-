using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Уп
{
    internal class Client
    {
     
            public string FIO { get; set; }
            public string Tel { get; set; }
            public string Adres { get; set; }
            public string Pass { get; set; }
        public string Uslug { get; set; }

            //public string YearPublished { get { return DatePublished.ToString("yyyy"); } }

            public Client(string fio, string tel,  string adres, string pass, string uslug)
            {
            FIO = fio;
            Tel = tel;
            Adres = adres; 
            Pass = pass;
            Uslug = uslug;
            }

            public override string ToString()
            {
                return "\tClient@" + GetHashCode() + "{\r\n" +
                    "\t\t FIO: " + FIO + "\r\n" +
                    "\t\t Tel: " + Tel + "\r\n" +
                   "\t\t Adres: " + Adres + "\r\n" +
                   "\t\t Tel: " + Pass + "\r\n" +
                    "\t}";
            }
        
    }
}

