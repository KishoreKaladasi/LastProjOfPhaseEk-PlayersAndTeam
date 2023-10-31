using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAndTeamProject
{
    public class OneDayTeam : ITeam
    {
        private int capacity;
        public OneDayTeam()
        {
            capacity = 9;
        }

        public static List<Player> Team = new List<Player>();
        


        public void Add()
        {
            Console.WriteLine("you have to add 11 players to a team ");
            Console.WriteLine("by defaulty I added 9 members then yo have to add 2 members");
            Team.Add(new Player { Playername = "Kishore", Playerid = 1, Playerage = 22 });
            Team.Add(new Player { Playername = "Manipaul", Playerid = 2, Playerage = 26 });
            Team.Add(new Player { Playername = "Raviteja", Playerid = 3, Playerage = 20 });
            Team.Add(new Player { Playername = "Charan", Playerid = 4, Playerage = 19 });
            Team.Add(new Player { Playername = "Ashok", Playerid = 5, Playerage = 30 });
            Team.Add(new Player { Playername = "Nagaraju", Playerid = 6, Playerage = 24 });
            Team.Add(new Player { Playername = "Hemanth", Playerid = 7, Playerage = 23 });
            Team.Add(new Player { Playername = "Joshi", Playerid = 8, Playerage = 25 });
            Team.Add(new Player { Playername = "Rohit", Playerid = 9, Playerage = 31 });

            while (capacity<11)
            {
                Console.WriteLine("Enter the playername as string ");
                string x = Console.ReadLine();
                Console.WriteLine("Enter the playerid as int ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the playerage as int ");
                int z = Convert.ToInt32(Console.ReadLine());
                Team.Add(new Player { Playername = x, Playerid = y, Playerage = z });


                capacity++;
            }
            Console.WriteLine("you want to show the all players-- press yes or no");
            string yesno = Console.ReadLine();
            if (yesno == "yes")
            {
                GetAllPlayers();
            }
            else
            {
                Console.WriteLine("thank you , you enetered players data sucessfully");
            }

        }
        public void Remove()
        {
            Console.WriteLine("Please enter the Id(int) of the Player You want to Remove");
            int playerIdToRemove = Convert.ToInt32(Console.ReadLine());

            Player playerToRemove = null;
            foreach (Player player in Team)
            {
                if (player.Playerid == playerIdToRemove)
                {
                    playerToRemove = player;
                    break;
                }
            }

            if (playerToRemove != null)
            {
                Team.Remove(playerToRemove);
                Console.WriteLine($"Player with ID {playerIdToRemove} has been removed from the team.");
            }
            else
            {
                Console.WriteLine($"Player with ID {playerIdToRemove} not found in the team.");
            }
        }

        public void GetPlayerById()
        {

            Console.WriteLine("Please enter the Id(int) of the Player You want");
            int getPlayerbyId = Convert.ToInt32(Console.ReadLine());

            Player getplayer = null;
            foreach (Player player in Team)
            {
                if (player.Playerid == getPlayerbyId)
                {
                    getplayer = player;
                    break;
                }
            }
            if (getplayer != null)
            {
                Console.WriteLine($"Player Name: {getplayer.Playername}, ID: {getplayer.Playerid}, Age: {getplayer.Playerage}");
                Console.WriteLine($"Player with ID {getPlayerbyId} has been caught from the team.");
            }
            else
            {
                Console.WriteLine($"Player with ID {getPlayerbyId} not found in the team.");
            }

         
        }
        public void GetPlayerByName()
        {
           

            Console.WriteLine("Please enter the Name(string) of the Player You want");
            string getPlayerbyName = Console.ReadLine();

            Player getplayer = null;
            foreach (Player player in Team)
            {
                if (player.Playername == getPlayerbyName)
                {
                    getplayer = player;
                    break;
                }
            }

            if (getplayer != null)
            {
                Console.WriteLine($"Player Name: {getplayer.Playername}, ID: {getplayer.Playerid}, Age: {getplayer.Playerage}");
                Console.WriteLine($"Player with ID {getPlayerbyName} has been caught from the team.");
            }
            else
            {
                Console.WriteLine($"Player with ID {getPlayerbyName} not found in the team.");
            }


        }

        // Here is the way of getting data from the onedayTeam list
        //public void GetAllPlayers()
        //{
        //    foreach (Player player in oneDayTeam)
        //    {
        //        Console.WriteLine($"playerName : {player.Playername}");
        //        Console.Write($"playerId : {player.Playerid}");
        //       Console.Write($"playerAge : {player.Playerage}");
        //    }
        //}


        //****************************************************************************************


        // Here is the way of getting data from the onedayTeam list by creating another list 
        //adding data of onedayTeam list to new list
        public void GetAllPlayers()
        {
            

            foreach (Player player in Team)
            {
                Console.WriteLine($"Player Name: {player.Playername}, ID: {player.Playerid}, Age: {player.Playerage}");
            }

            
        }
    }
}
