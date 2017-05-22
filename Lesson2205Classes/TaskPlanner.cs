using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson2205Classes
{
    class TaskPlanner
    {
        private class Job
        {
            public int Delay;
            public Action Action;
        }
        private int quant;
        private List<Job> actionsToDo = new List<Job>();
        public TaskPlanner(int quant)
        {

        }

        public void SheduleLJob()
        {

        }

        public void Work()
        {
            while (true)
            {
                Thread.Sleep(quant);
                foreach (var item in actionsToDo)
                    item.Delay -= quant;
            }
        }
    }
}
