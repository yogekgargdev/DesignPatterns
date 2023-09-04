using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPractise
{
    public sealed class SingletonImplementaion
    {
        private static SingletonImplementaion Instance = null;
        private static int Counter =0;

        public static SingletonImplementaion GetInstance() { 
        
            if (Instance == null)
            {
                Instance = new SingletonImplementaion();
            }
            return Instance;    
        }

        private SingletonImplementaion() {

            Counter++;
            Console.WriteLine("No of times SingletonImplementaion Class is initiated " + Counter);
        }

        public void PrintMessge(string message) { 
        
            Console.WriteLine(message); 
        }
    }
}
