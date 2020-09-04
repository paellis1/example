using System;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuInput = 0;
            while(menuInput != 3)
            {
                Console.WriteLine("Please enter 1. Say hello 2. To say howdy 3. to exit");
                try{
                    menuInput = int.Parse(Console.ReadLine());
                }
                catch(Exception e){
                    Console.WriteLine(e.Message);

                }
            }
    }
}
