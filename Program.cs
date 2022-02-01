using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => Singleton.GetSingleton(),
                () => Singleton.GetSingleton()

                ); ;
        }
    }
}
