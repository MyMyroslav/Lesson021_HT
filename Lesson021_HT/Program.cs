using System;
using System.Threading;

namespace Lesson021_HT
{
    class MainClass
    {
        static object lockFlag = new Object();
        static void Recurse(object remaining)
        {
            lock (lockFlag)
            {
                if ((int)remaining <= 0)
                {
                    return;
                }
                Thread thread = new Thread(Recurse);
                thread.Start((int)remaining - 1);
                Console.WriteLine(remaining);
            }
        }
        public static void Main(string[] args)
        {
            Recurse(1000);
        }
    }
}
