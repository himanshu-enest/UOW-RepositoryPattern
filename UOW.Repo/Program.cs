using Autofac;
using System;
using UOW.Repo.Business.Interface;

namespace UOW.Repo
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = AutofacConfiguration.Configure();
            var _testService = container.Resolve<ITestAppService>();

            Console.Write("Enter number whose square you want to calculate: ");
            var number = Console.ReadLine();

            bool isSussecc = int.TryParse(number, out int result);

            if (isSussecc)
            {
                
            }
            if (!isSussecc)
            {
                Console.WriteLine("You should have entered an integer value.");
            }

            Console.ReadKey();
            
        }
    }
}
