using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace Server_tic_tac_to_
{
    class Server
    {
        static TcpClient p1, p2;
        static void Main(string[] args)
        {
            TcpListener server = new TcpListener(9246);
            server.Start();
            int j;

            for (int i = 1; i <= 2; i++)
            {

                TcpClient c = server.AcceptTcpClient();
                if (i == 1)
                    p1 = c;
                else
                    p2 = c;

            }
            BinaryFormatter fobj = new BinaryFormatter();
            fobj.Serialize(p1.GetStream(), "X");
            fobj.Serialize(p2.GetStream(), "0");
            string pmsg;

            for (j = 0; j<=4; j++)
            {
                pmsg = (string)fobj.Deserialize(p1.GetStream());
                fobj.Serialize(p2.GetStream(), pmsg);
                if (j == 4)
                    break;
                pmsg = (string)fobj.Deserialize(p2.GetStream());
                fobj.Serialize(p1.GetStream(), pmsg);
          
              
                
            }
            Console.ReadKey();

          
        }
    }
}
