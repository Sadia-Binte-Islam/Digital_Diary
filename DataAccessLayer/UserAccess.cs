﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Diary.DataAccessLayer
{
    class UserAccess
    {
        
        
            DataAccess dataAccess;
            public UserAccess()
            {
                this.dataAccess = new DataAccess();
            }
            public bool LoginValidation(string username, string password)
            {
                string sql = "SELECT * FROM t_users WHERE Username='" + username + "' AND Password='" + password + "'";
                SqlDataReader reader = dataAccess.GetData(sql);
                if (reader.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

          
        }
    }

