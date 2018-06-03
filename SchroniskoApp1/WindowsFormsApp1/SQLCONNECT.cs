using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace WindowsFormsApp1
{
    class SQLCONNECT
    {
        public OracleConnection nowe_polaczenie = new OracleConnection();

        public void Connection()
        {
            nowe_polaczenie.Close();

            nowe_polaczenie.ConnectionString =
                "User Id=" + "njakubi1"
                + ";Password=" + "njakubi1"
                + ";Data Source=(DESCRIPTION="
                + "(ADDRESS=(PROTOCOL=TCP)(HOST=ora3.elka.pw.edu.pl)(PORT=1521))"
                + "(CONNECT_DATA=(SID=ora3inf)));";
            nowe_polaczenie.Open();
        }
    }
}
