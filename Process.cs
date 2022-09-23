using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Process
    {
        int idProcess;
        string name;
        enum status
        {
            Ready,
            Active,
            Waiting,
            Zombie
        }
        int timeUsed=0;
        int timeResults=0;
        string basePriority= "low";
        string currentPriority="hight";

        private Process(int idProcess, string basePriority)
        {
            this.idProcess = idProcess;
            this.basePriority = basePriority;
        }

        private void Go () {
            timeUsed++; 
        }
    }
}
