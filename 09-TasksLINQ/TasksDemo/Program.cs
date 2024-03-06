using System.Runtime.Intrinsics.X86;

namespace TasksDemo
{
    internal class Program
    {
        static void MethodOne()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("---> M1\t" + i);
                Thread.Sleep(1000);
            }
        }
        
        static void Main(string[] args)
        {
            //From yesterday
            //Thread trd = new Thread(MethodOne);
            //trd.Start();

            //ThreadPool
            //ThreadPool.QueueUserWorkItem(
            //    (x) =>
            //    {
            //        Console.WriteLine("work item x is running throught the threadPool");
            //        for (int i = 0; i < 11; i++) 
            //        {
            //            Console.WriteLine(i);
            //            Thread.Sleep(500);
            //        }
            //    }); //Task/work item will run in the background (main will terminate whether task is finished or not)
            //Console.WriteLine("Main thread finished!");

            //Console.ReadKey(); // main thread listening, so the background task can run

            // Tasks
            // 3 ways to define tasks

            // first way to define tasks
            //Task t1 = new Task(MethodOne);
            //t1.Start();
            //t1.Wait(); // Thread: Join(), Task: Wait()

            // second way to define tasks
            //Task t2 = Task.Factory.StartNew(MethodOne); //starts by itself
            //t2.wait();

            // third way to define tasks
            //Task t3 = Task.Run(MethodOne); //starts by itself, can you lambda

            // Task with return tyupe
            //Task<int> t4 = Task.Run(() => { return 9; });
            //Console.WriteLine("t4 result -> " + t4.Result);

            // ContinueWith
            //Task<string> news = Task.Run(
            //    () => { return "Here are the news for today: "; }
            //    ).ContinueWith(
            //    (moreNews) => { return moreNews.Result + "\nMand faldet af stol"; }
            //    ).ContinueWith(
            //    (evenMoreNews) => { return evenMoreNews.Result + "\nKvinde købt stort brød ved bageren"; }
            //);
            //Console.WriteLine(news.Result);

            //wait(), waitAny(), WaitAll()
            //Task[] tasks = new Task[3];
            //tasks[0] = Task.Run(() =>
            //{
            //    Thread.Sleep(7000);
            //    Console.WriteLine("Task[0] finished in 7 seconds");
            //});
            //tasks[1] = Task.Run(() =>
            //{
            //    Thread.Sleep(5000);
            //    Console.WriteLine("Task[1] finished in 5 seconds");
            //});
            //tasks[2] = Task.Run(() =>
            //{
            //    Thread.Sleep(3000);
            //    Console.WriteLine("Task[2] finished in 3 seconds");
            //});

            //Task.WaitAny(tasks);//waits for any one of the tasks are done
            //Task.WaitAll(tasks);//waits for all tasks are done

            //Task with List
            //List<Task<string>> taskList = new List<Task<string>> ();
            //taskList.Add(Task.Run(() => { Thread.Sleep(3000); return "Cat"; }));
            //taskList.Add(Task.Run(() => { Thread.Sleep(5000); return "Armadillo"; }));
            //taskList.Add(Task.Run(() => { Thread.Sleep(9000); return "Bat"; }));
            //taskList.Add(Task.Run(() => { Thread.Sleep(7000); return "Sloth"; }));
            //taskList.Add(Task.Run(() => { Thread.Sleep(6000); return "Hedgehod"; }));
            //taskList.Add(Task.Run(() => { Thread.Sleep(9999); return "Sofus"; }));

            //while (taskList.Count > 0)
            //{
            //    //waitAny return an int - and is most commonly used with arrays
            //    int index = Task.WaitAny(taskList.ToArray());
            //    Task<string> completedTask = taskList[index];
            //    taskList.RemoveAt(index);
            //    Console.WriteLine($"\n{ completedTask.Result } is finally waking up");
            //}


            TaskHandler th = new TaskHandler();
            //th.LangsomMetode();
            //th.AndenMethode();


            //overall homepage can give to answers html or json (most often from API's)
            //Console.WriteLine(th.DownloadContent("https://www.dmi.dk").Result); //returns html
            //Console.WriteLine(th.DownloadContent("https://swapi.dev/api/people/1/").Result); //returns json
            Console.WriteLine("Main thread done!");
            
            Console.ReadKey();

        }
    }
}
