using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;

namespace Super_StartByConfig
{
    public class TelnetSession : AppSession<TelnetSession>
    {
        protected override void OnSessionStarted()
        {
            //this.Send("Welcome to SuperSocket Telnet Server");
        }

        protected override void HandleUnknownRequest(StringRequestInfo requestInfo)
        {
            this.Send("sum connected is: "+this.AppServer.SessionCount);
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
