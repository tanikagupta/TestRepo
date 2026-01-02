using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training
{
    class FootballPlayer
    {
        //Name, Team, GoalsScored, GamesPlayed : get;set;

        List<FootballPlayer> listPlayers = new List<FootballPlayer>();

        public string Name { get; set; }
        public string Team { get; set; }

        public int GoalsScored { get; set; }

        public int GamesPlayed { get; set; }

        public void CreateFootballPlayersList() {

            char choice;

            do
            {
                FootballPlayer player = new FootballPlayer();

                Console.WriteLine("Enter Player's Name");
                player.Name = Console.ReadLine();

                Console.WriteLine("Enter Team Name");
                player.Team = Console.ReadLine();

                Console.WriteLine("Enter the Games Played");

                if (Console.ReadLine() == string.Empty)
                {
                    Console.WriteLine("Please Enter the Games Played to proceed further");
                    if (Console.ReadLine() == string.Empty)
                    {
                        Console.WriteLine("Since nothing has been entered in games played, so we are exiting the app.");
                        break;
                    }
                }
                player.GamesPlayed = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Goals Scored");
                player.GoalsScored = Convert.ToInt32(Console.ReadLine());

                listPlayers.Add(player); //adding the player to the list of football players


                Console.WriteLine("Do you want add another Player ? (Y/N)");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (char.ToUpper(choice) == 'Y');

            Console.WriteLine("Details of the Players are ----");
            bool anyQualifiedPlayer = false;

            foreach (var p in listPlayers) {
                if (p.GoalsScored >= 1)
                {
                    Console.WriteLine($"Name : {p.Name}, Team : {p.Team}, GamesPlayed : {p.GamesPlayed}, GoalsScored : {p.GoalsScored}");
                    anyQualifiedPlayer = true;
                }            
            }

            if (anyQualifiedPlayer == false)
            {
                Console.WriteLine("No goals scored by any player.");
            }

            Console.WriteLine("Press any key to Exit-------");
            Console.ReadKey();
        }
    }

}
