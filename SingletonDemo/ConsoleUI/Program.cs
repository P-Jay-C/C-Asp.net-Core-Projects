
using System.Runtime.CompilerServices;
using ConsoleUI;

TableServers host1List = TableServers.GeTableServers();
TableServers host2List = TableServers.GeTableServers();


for (int i = 0; i < 10; i++)
{
    //Console.WriteLine("The next server is: " + servers.GetNextServer());
    Host1GetNextServer();
    Host2GetNextServer();
}

void Host1GetNextServer()
{
    Console.WriteLine("The next server is: " + host1List.GetNextServer());
}

void Host2GetNextServer()
{
    Console.WriteLine("The next server is: " + host2List.GetNextServer());
}





