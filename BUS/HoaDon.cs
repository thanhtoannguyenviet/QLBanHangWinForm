using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDon
    {
        public DataTable GetAllHoaDon()
        {
            DataTable data = new DataTable();
            string strquery = "Select * from data";

            using (SqlConnection con = DBUtils.GetDBConnection())
            using (SqlCommand cmd = new SqlCommand(strquery, con))
            {
                con.Open();
                data.Load(cmd.ExecuteReader());
                return data;
            }
        }
    }
}
