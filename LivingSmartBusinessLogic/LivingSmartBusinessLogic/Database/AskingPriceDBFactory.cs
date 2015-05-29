﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.DB
{
    internal static class AskingPriceDBFactory
    {
        public static IAskingPriceDB GetDBL()
        {
            if (Properties.Settings.Default.DatabaseType == "MSSQL")
                return new AskingPriceDBMSSQL();
//            if (Properties.Settings.Default.Database == "XML")
//                return new CustomerDBXML();
//            if (Properties.Settings.Default.Database == "MYSQL")
//                return new CustomerDBMYSQL();
            return null;
        }
    }
}
