using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccess_DVLD
{
    public class clsConnectionSetting
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["DVLD-SystemDB"].ConnectionString;
    }
}
