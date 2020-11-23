using System;

namespace OPSuperHeores
{
    class Program
    {
        class player
        {
            string name;
            int hp;

            //constructor
            public player(string _name)
            {
                name = _name;
                Random rnd = new Random();
                hp = rnd.Next(100, 151);
            }

            public void SayHello()
            {
                Console.WriteLine($"{name} says Hello!");

            }
            public void ShowYourHp()
            {
                Console.WriteLine($"{name}'s HP: {hp}");
            }

            public int MakeDamage()
            {
                Random rnd = new Random();
                return rnd.Next(10, 51);
            }


            public void TakeDamage(int damage)
            {
                if(hp <=0)
                {
                    hp = 0;
                }else
                {
                    hp = hp - damage;
                }
            }
            public int HP
            {
                get { return hp; }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Name your first character");
            string characterName = Console.ReadLine();
            Console.WriteLine("Name your second character");
            string characterNameTwo = Console.ReadLine();


            player playerOne = new player(characterName);
            player playerTwo = new player(characterName);
            playerOne.SayHello();
            playerOne.ShowYourHp();
            playerTwo.SayHello();
            playerTwo.ShowYourHp();
            
            for(int i= 0; i<3; i++)
            {
                playerOne.TakeDamage(playerTwo.MakeDamage());
                playerTwo.TakeDamage(playerTwo.MakeDamage());
                playerOne.ShowYourHp();
                playerTwo.ShowYourHp();
            }
            
            if(playerOne.HP > playerTwo.HP)
            {
                Console.WriteLine($"playerOne won!");
            }else if (playerOne.HP < playerTwo.HP)
            {
                 Console.WriteLine($"playerTwo won!");
            } 
             else
                {
                    Console.WriteLine($"Player One hit{playerOne.MakeDamage()}");
                }
                
            }
           
            
            

        
    }
}
