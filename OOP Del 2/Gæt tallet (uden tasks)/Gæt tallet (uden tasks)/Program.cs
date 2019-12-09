using System;

namespace Gæt_tallet__uden_tasks_
{
    class Program
    {
        static void Main(string[] args)
        {
            float savedtime = DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
            int countdown = 0;
            while (true)
            {
                
                float looptime = DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
                if (Console.KeyAvailable)
                {
                    Console.ReadKey();
                    Console.WriteLine(savedtime);
                }
                if (looptime - savedtime > 1000 && looptime - savedtime < 50000)
                {
                    
                    Console.WriteLine(countdown);
                    savedtime = looptime;
                    if (savedtime >= 59000)
                    {
                        savedtime -= 60000;
                    }
                    countdown += 1;
                }
                
            }
        }
    }
}
