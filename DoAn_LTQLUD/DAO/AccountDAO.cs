﻿using POS.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DoAn_LTQLUD.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "SELECT * FROM dbo.UserID WHERE Username = N'" + userName + "' AND Password = N'" + passWord + "'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, null);

            return result.Rows.Count > 0;
        }
    }
}
