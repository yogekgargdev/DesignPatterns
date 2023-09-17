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
        private static Object object1 = new object();
        private static int Counter =0;

        public static SingletonImplementaion GetInstance() {

            // Double Checked Locking, since locking an object can be a costly operation (optional)
            if (Instance == null)
            {
                lock (object1)
                {
                    if (Instance == null)
                    {
                        Instance = new SingletonImplementaion();
                    }
                }
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
