using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class TableServers
    {
        private static readonly TableServers _instance = new TableServers();

        private List<string> servers = new List<string>();
        private int nextServer = 0;

        private TableServers()
        {
            servers.Add("Tim");
            servers.Add("Sue");
            servers.Add("Mary");
            servers.Add("Tom");
        }

        public static TableServers GeTableServers()
        {
            return _instance;
        }
        public string GetNextServer()
        {
            string output = servers[nextServer];
            nextServer += 1;

            if (nextServer >= servers.Count)
            {
                nextServer = 0;
            }

            return output;
        }
    }
}