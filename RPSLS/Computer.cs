using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        public Computer()
        {

        }
        public override void ItemSelect()
        {
            Random AiChoice = new Random();
            ItemChoice = items[AiChoice.Next(1, items.Count)];
        }
        public override void DisplayChoice()
        {
            switch (ItemChoice)
            {
                case 1:
                    Console.WriteLine("Computer chose: Rock");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Computer chose: Paper");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Computer chose: Scissors");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Computer chose: Lizard");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Computer chose: Spock");
                    Console.ReadLine();
                    break;
            }

        }
    }
}
