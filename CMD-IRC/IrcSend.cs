using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDIRC
{
    class IrcSend
    {
       
        //program function

        //this is where different kind of messages can be send to the server
        public static void sendMsg(string Input)
        {
            if (Input.Contains("xdcc send"))
            {
                string[] xdccparts = Input.Split(' ');
                string xdccdl = "PRIVMSG " + xdccparts[1] + " :XDCC SEND " + xdccparts[4];
                Console.WriteLine("RareIRC: XDDC request : " + xdccdl);
                IrcConnect.writeIrc(xdccdl);
            }
            else if (Input.Contains("XDCC CANCEL"))
            {
                string[] xdccparts = Input.Split(' ');
                string xdcccl = "PRIVMSG " + xdccparts[1] + " :XDCC CANCEL";
                Console.WriteLine("RareIRC: XDDC CANCEL : " + xdcccl);
                IrcConnect.writeIrc(xdcccl);
            }
            else if (Input.Contains("/quit"))
            {
                IrcConnect.writeIrc("PRIVMSG " + IrcConnect.newChannel + " : QUIT");
            }
            else
            {
                IrcConnect.writeIrc("PRIVMSG " + IrcConnect.newChannel + " :" + Input);
            }
            
        }
        //actually sends it to the server with a function defined in IrcConnect
        public static void sendInput(string Input)
        {
            IrcConnect.writeIrc(Input);
        }
       
    }
}
