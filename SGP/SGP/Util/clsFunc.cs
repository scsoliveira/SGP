﻿using System;
using System.Data.SqlClient;
namespace DentalManagementSystem
{
    class clsFunc
    {
        CommonClasses cc = new CommonClasses();
        ConnectionString cs = new ConnectionString();
        public void LogFunc(string st1, DateTime st2, string st3)
        {
           
            cc.con = new SqlConnection(cs.DBConn);
            cc.con.Open();
            string cb = "insert into Logs(UserID,Data,Operacao) VALUES (@d1,@d2,@d3)";
            cc.cmd = new SqlCommand(cb);
            cc.cmd.Connection = cc.con;
            cc.cmd.Parameters.AddWithValue("@d1",st1);
            cc.cmd.Parameters.AddWithValue("@d2",st2);
            cc.cmd.Parameters.AddWithValue("@d3",st3);
            cc.cmd.ExecuteReader();
            cc.con.Close();
        }
    }
}
