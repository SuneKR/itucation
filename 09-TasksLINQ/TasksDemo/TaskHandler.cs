using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksDemo
{
    public class TaskHandler
    {
        public void LangsomMetode()
        {
            Thread.Sleep(10000);
            Console.WriteLine("Langsom metode er færdig");
        }
        public async Task AndenMethode()
        {
            Console.WriteLine("Task is running somewhere asynchonously .... main, you don't have to wait!");
            await Task.Run(LangsomMetode); // controll goes back to main when tasks finished
            Console.WriteLine("Anden metode er færdig");
        }
        public async Task<string> DownloadContent(string url)
        {
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync(url);
            return result;
        }

    }
}
