using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAndTeamProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OneDayTeam team = new OneDayTeam();


            while (true)
            {
                Console.WriteLine("Hi Admin");
                Console.WriteLine("Welcome to the Team Management");
                Console.WriteLine("Press 1 for Add players to the Team");
                Console.WriteLine("Press 2 for Remove players to the Team");
                Console.WriteLine("Press 3 for get All players from the Team");
                Console.WriteLine("Press 4 for search player by Id");
                Console.WriteLine("Press 5 for search player by Name");
                Console.WriteLine("************************************");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        team.Add();
                        Console.WriteLine("************************************");
                        Console.WriteLine("press enter for menu");
                        break;
                    case 2:
                        team.Remove();
                        
                        Console.WriteLine("************************************");
                        Console.WriteLine("press enter for menu");
                        break;
                    case 3:
                        team.GetAllPlayers();
               
                        Console.WriteLine("************************************");
                        Console.WriteLine("press enter for menu");
                        break;
                    case 4:
                        team.GetPlayerById();
                   
                        Console.WriteLine("************************************");
                        Console.WriteLine("press enter for menu");
                        break;
                    case 5:
                        team.GetPlayerByName();
                      
                        Console.WriteLine("************************************");
                        Console.WriteLine("press enter for menu");
                        break;
                    default:
                        Console.WriteLine("Please enter valid choice");
              
                        Console.WriteLine("************************************");
                        Console.WriteLine("press enter for menu");
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}
