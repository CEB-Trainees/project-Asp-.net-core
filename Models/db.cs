﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;
using CoreLogin.Models;
namespace CoreLogin.Models
{
    public class db
    {
        SqlConnection con = new SqlConnection("Data Source=ADMINRG-N8EO0RN\\SQLEXPRESS;Initial Catalog=testdb;Integrated Security=True");
        public int LoginCheck(Ad_login ad)
        {
            SqlCommand com = new SqlCommand("Sp_Login", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Admin_id", ad.Admin_id);
            com.Parameters.AddWithValue("@Password", ad.Ad_Password);
            SqlParameter oblogin = new SqlParameter();
            oblogin.ParameterName = "@Isvalid";
            oblogin.SqlDbType = SqlDbType.Bit;
            oblogin.Direction = ParameterDirection.Output;
            com.Parameters.Add(oblogin);
            con.Open();
            com.ExecuteNonQuery();
            int res = Convert.ToInt32(oblogin.Value);
            con.Close();
            return res;
        }
    }
}