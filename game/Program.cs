using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace game
{
    internal class Program
    {
        public static int checkSpeed()
        {
            Console.WriteLine("what text speed do you want");


            
            while (true)
            {
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch 
                {
                    Console.Clear();
                    Console.WriteLine("please write a valid answer from 1-3");
                }   
            }
        }

        static void Main(string[] args)
        {
            slowWriter slow = new slowWriter(checkSpeed());
            game game = new game(slow);
            game.start();
        }
    }
}
