using System;

namespace Google.Maps.Geocoding.Core.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = TestCoder.AllAsync();

            task.Wait();

            Console.WriteLine(string.Empty);
            Console.WriteLine("Press any key to finish");
            Console.ReadKey();
        }
    }
}
