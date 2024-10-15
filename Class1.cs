using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Уп
{
    static class Reader
    {
        public static OleDbConnection Connection
        {
            get
            {
                return new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Провайдер.accdb");
            }
        }
    }
}
