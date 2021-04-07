using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;
using System.Data.Common;
using System.Data;
using Microsoft.Data.SqlClient;

namespace KalendarScopic.Web.DAL
{
    public static class DBHelper
    {
        private static string connection {
            get
            {
                return @"Data Source=PC-PC\SQLEXPRESS;
                        Initial Catalog=KalendarScopicDB;
                        Integrated Security=true";

            }
                }

        public static int ExecuteNonQuery(string storedProcedure, params object[] parameters)
        {
            int returnResult = 0;
            using (var cn = new SqlConnection(connection))
            {
                using (var cmd = new SqlCommand(storedProcedure, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters.Length > 0)
                    {
                        for (int i = 0; i < parameters.Length; i += 2)
                        {
                            cmd.Parameters.AddWithValue(parameters[i].ToString(), parameters[i + 1]);
                        }
                    }
                    cn.Open();
                    returnResult = cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            return returnResult;
        }
    }
}
