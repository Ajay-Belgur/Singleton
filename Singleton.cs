using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private int counter = 0;
        private static int invokeCounter = 0;
        private static Object obj = new object();


        //lazy loading
        //private Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());
        private Singleton()
        {
            
            Console.WriteLine($"Instance Counter : {++counter}");
        }

        public static Singleton GetSingleton()
        {

            Console.WriteLine($"Invoke counter : {++invokeCounter}");
            if (instance == null)
            {
                lock (obj)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                        return instance;
                    }
                    //return instance;
                }
            }
            return instance;
        }


    }
}
