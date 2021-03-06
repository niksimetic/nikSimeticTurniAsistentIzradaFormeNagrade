﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikSimeticTurnirAsisten
{
    public static class GlobalConfig 
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnections(bool database, bool textfiles)
        {
            if (database)
            {
                // napravit - napravi sql connection tocnno
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }
            if (textfiles)
            {
                // napravit - text connection
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}
