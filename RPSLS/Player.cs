using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        public string name;
        public int ItemChoice;
        public int score;
        public List<int> items;

        public Player()
        {
            items = new List<int>() { 0, 1, 2, 3, 4, 5 };

        }

        public virtual void ItemSelect()
        {
            Console.WriteLine("Select your Gesture:\n 1 = Rock \n 2 = Paper \n 3 = Scissors \n 4 = Lizard \n 5 = Spock ");
            ItemChoice = int.Parse(Console.ReadLine());
        }

        public virtual void DisplayChoice()
        {
            switch (ItemChoice)
            {
                case 1:
                    Console.WriteLine("You chose: Rock");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("You chose: Paper");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("You chose: Scissors");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("You chose: Lizard");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("You chose: Spock");
                    Console.ReadLine();
                    break;
            }

        }

    }
}
