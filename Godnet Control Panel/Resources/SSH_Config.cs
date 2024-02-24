using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godnet_Control_Panel.Resources
{
    public class SSH_Config
    {
        public static SftpClient sshInfo(string host, string username, string password)
        {
            return new SftpClient(host, 22, username, password);
        }
    }
}
