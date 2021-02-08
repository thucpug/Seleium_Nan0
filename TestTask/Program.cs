using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestTask
{
    class Program
    {
        public class TestAsync
        {
            public static void WriteLine(string s, ConsoleColor color)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(s);
            }
            // Tạo và chạy Task, sử dụng delegate Func (có kiểu trả về)
            public  static async Task<string> Async1(string thamso1, string thamso2)
            {
                // tạo biến delegate trả về kiểu string, có một tham số object
                Func<object, string> myfunc = (object thamso) =>
                {
                    // Đọc tham số (dùng kiểu động - xem kiểu động để biết chi tiết)
                    dynamic ts = thamso;
                    for (int i = 1; i <= 10; i++)
                    {
                        //  Thread.CurrentThread.ManagedThreadId  trả về ID của thread đạng chạy
                        WriteLine($"{i,5} {Thread.CurrentThread.ManagedThreadId,3} Tham số {ts.x} {ts.y}",
                            ConsoleColor.Green);
                        Thread.Sleep(1000);
                    }
                    return $"Kết thúc Async1! {ts.x}";
                };

                Task<string> task = new Task<string>(myfunc, new { x = thamso1, y = thamso2 });
                task.Start(); // chạy thread
                //task.Wait();
                await task;
                Console.WriteLine(task.Result);
                // Làm gì đó sau khi chạy Task ở đây
                Console.WriteLine("Async1: Làm gì đó sau khi task chạy");
                return  task.Result;
            }

            // Tạo và chạy Task, sử dụng delegate Action (không kiểu trả về)
            public static Task Async2()
            {

                Action myaction = () =>
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        WriteLine($"{i,5} {Thread.CurrentThread.ManagedThreadId,3}",
                            ConsoleColor.Yellow);
                        Thread.Sleep(2000);
                    }
                };
                Task task = new Task(myaction);
                task.Start();

                // Làm gì đó sau khi chạy Task ở đây
                Console.WriteLine("Async2: Làm gì đó sau khi task chạy");

                return task;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            TestAsync.Async1("thuc1", "thuc2");
            TestAsync.Async2();
            Console.ReadKey();
        }
    }
}
