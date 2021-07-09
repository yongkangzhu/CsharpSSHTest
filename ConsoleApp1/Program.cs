using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var sshClient = new SshClient("127.0.0.1", 2222, "root", "vagrant"))
            {
                sshClient.Connect();

                string cmd1 = "cd /;ls -l";

                using (var cmd = sshClient.CreateCommand(cmd1))
                {
                    var res = cmd.Execute();

                    var arr = res.Split('\n');
                    var arr2 = arr[1].Split('\t');
                    Console.Write(res);

                    Console.ReadKey();


                }
            }
        }
    }
}
