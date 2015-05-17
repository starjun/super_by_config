using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;

namespace Super_StartByConfig
{
    public class mmlog : CommandBase<TelnetSession, StringRequestInfo>
    {
        public override void ExecuteCommand(TelnetSession session, StringRequestInfo requestInfo)
        {
            //session.Send(requestInfo.Parameters.Select(p => Convert.ToInt32(p)).Sum().ToString());
            session.Send(requestInfo.Body);
        }
    }
}
