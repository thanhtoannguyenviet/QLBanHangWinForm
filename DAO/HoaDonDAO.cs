using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonDAO
    {
        public static DataTable GetAllHoaDon()
        {
            DataTable data = new DataTable();
            string strquery = "Select * from HOADON";

            using (SqlConnection con = DBUtils.GetDBConnection())
            using (SqlCommand cmd = new SqlCommand(strquery, con))
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                data.Load(reader);
                return data;
            }
        }
    }
}
