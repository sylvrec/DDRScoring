using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDDRScoring
{
    public class TestBase
    {
        public TestContext TestContext { get; set; }
        public DataTable TestDataTable { get; set; }

        public DataTable LoadDataTable(string sql, string connection)
        {
            TestDataTable = null;

            try
            {
                using (SqlConnection connectionObject = new(connection))
                {
                    using (SqlCommand commandObject = new SqlCommand(sql, connectionObject))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(commandObject))
                        {
                            TestDataTable = new DataTable();
                            da.Fill(TestDataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                TestContext.WriteLine("Error in LoadDataTable() method." + Environment.NewLine + ex.Message);
                return null;
            }
            return TestDataTable;
        }

    }
}
