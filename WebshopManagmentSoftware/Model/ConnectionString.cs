﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopManagmentSoftware.Model
{
    public class ConnectionString
    {
        public string getCreateString()
        {
            return
                "SERVER=\"localhost\";"
                + "DATABASE=\"test\";"
                + "UID=\"root\";"
                + "PASSWORD=\"\";"
                + "PORT=\"3306\";";
        }

        public string getConnectionString()
        {
            return
             "SERVER=\"localhost\";"
             + "DATABASE=\"webshoptest\";"
             + "UID=\"root\";"
             + "PASSWORD=\"\";"
             + "PORT=\"3306\";";
        }
    }
}
