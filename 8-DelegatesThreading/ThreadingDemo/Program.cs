namespace ThreadingDemo
{
    internal class Program
    {
        static void MethodOne()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("--> M1\t" + i);
                Thread.Sleep(1000);
            }
        }
        static void MethodTwo()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("--> M2\t" + i);
                Thread.Sleep(1000);
            }
        }
        static void ParamMethod(object x) //ParameterizedThreadStart() kræver et object, derfor kan parametret ikke hedde int x
        {
            for (int i = 0; i <= (int)x; i++)
                {
                Console.WriteLine("---> MP\t " + i);
                Thread.Sleep(1000);
            }
        }
        static int amount = 0;
        static void Deposit(object n)
        {
            for(int i = 0; i <= (int)n; i++)
            {
                amount++;
            }
        }
        static void DoubleMyMoney(int depositAmount)
        {
            Thread depTrd1 = new Thread(Deposit);
            Thread depTrd2 = new Thread(Deposit);
            depTrd1.Start(depositAmount);
            depTrd2.Start(depositAmount);
            depTrd1.Join();
            depTrd2.Join();
        }
        static void Main(string[] args)
        {
            //run MethodsOne and MethodsTwo one after the other
            //MethodOne(); 
            //MethodTwo();

            //run MethodsOne and MethodsTwo in different threads
            //Thread trd1 = new Thread(MethodOne);
            //Thread trd2 = new Thread(MethodTwo);
            //trd1.Start();
            //trd2.Start();
            //Main tread will print the console.writeline below after one iteration, because it's own thread

            //unless thread is join
            //trd1.Join();
            //trd2.Join();

            //Console.WriteLine("Main thread done!"); 


            //Thread trd3 = new Thread(new ParameterizedThreadStart(ParamMethod));
            //trd3.Start(5);
            //trd3.Join();

            //bool doNotStop = true;
            //Thread trd4 = new Thread(
            //    () => {
            //        while (doNotStop)
            //        {
            //            Console.WriteLine("I'm not stopping!");
            //            Thread.Sleep(500);
            //        }
            //    });
            //trd4.Start();
            //Thread.Sleep(5000); //Main thread
            //doNotStop = false;

            DoubleMyMoney(100000);
            Console.WriteLine(amount);

            Console.WriteLine("Main thread done!"); 
        }
    }
}
