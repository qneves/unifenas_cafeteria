using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nCafeteria
{
    public class DataBase
    {
        public string getConnectionString()
        {
            return "SERVER = NEVES\\SQLEXPRESS;Database=Cafeteria;UID=sa;PWD=12345;";
        }
    }
}
