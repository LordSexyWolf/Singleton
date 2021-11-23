using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SingletonDemo
{
    public class Singleton
    {
        private static int counter = 0;
        private static object obj = new object();

        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static Singleton instance = null;

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        public class DerivedSingleton : Singleton
        {

        }
    }
}