using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Singleton
{
    class SingletonDemo
    {
        public static SingletonDemo _obj;
        public static int count = 0;
        private SingletonDemo()
        {

        }
        public static SingletonDemo GetObject()
        {
            if (_obj == null)
            {
                _obj = new SingletonDemo();
                count++;
            }
            return _obj;
        }
        public void Print(string s)
        {
            Console.WriteLine(s+" Current Session : "+count);
        }
    }
}
