using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
using SuperSocket.SocketBase.Command;

namespace Super_StartByConfig
{
    public class TSession : AppSession<TSession>
    {
        protected override void OnSessionStarted()
        {
            //this.Send("Welcome to SuperSocket Telnet Server");
        }

        protected override void HandleUnknownRequest(StringRequestInfo requestInfo)
        {
            switch (requestInfo.Key.ToUpper())
            {
                //case "ECHO":
                //    this.Send(requestInfo.Body);
                //    break;
                case "ADD":
                    this.Send(requestInfo.Parameters.Select(p => Convert.ToInt32(p)).Sum().ToString());
                    break;
                case "MULT":
                    var result = 1;
                    foreach (var factor in requestInfo.Parameters.Select(p => Convert.ToInt32(p)))
                    {
                        result *= factor;
                    }

                    this.Send(result.ToString());
                    break;
                default:
                    this.Send("Unkown Cli   "+this.AppServer.SessionCount);
                    break;
            }

        }

        protected override void HandleException(Exception e)
        {
            this.Send("Application error: {0}", e.Message);
        }

        protected override void OnSessionClosed(CloseReason reason)
        {
            base.OnSessionClosed(reason);
        }


        
    }
}
