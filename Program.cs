using System;
using Ajira.ProblemOfKing.Model;
using Ajira.ProblemOfKing.Constants;
using System.Collections.Generic;
using System.Text;

namespace Ajira.ProblemOfKing
{
    class Program
    {

        static void Main(string[] args)
        {
            Army kingsArmy = new Army();
            Army opponentArmy = new Army();

            Dictionary<string, int> kings = new Dictionary<string, int>();
            Dictionary<string, int> opponent = new Dictionary<string, int>();

            Console.WriteLine("Initializing Our Army");

            // User Input will come here 
            var readOurArmy = Console.ReadLine();

            // Then We need to break our platoon entry into list , and assign them
            var ourPlatoonList = readOurArmy.Split(";");

            // Assign Toop to respective classes
            AssignArmy(ourPlatoonList, kingsArmy, kings);

            Console.WriteLine("========================================");
            Console.WriteLine("Initializing Opponent Army");
            // Then there will be user input for opponent will come here 
            var readOpponentArmy = Console.ReadLine();

            // Then we need to break their (opponent) platoon in the same fashion and store it. 
            var opponentPlatoonList = readOpponentArmy.Split(";");

            AssignOpponentArmy(opponentPlatoonList, opponentArmy, opponent);

            Console.WriteLine("========================================");
            Console.WriteLine("Starting to analyze the sequence of Kings Army...");

            string result =  BattleFormation.StartingBattleFormationAnalysis(kings, opponent);

            Console.WriteLine(result);

            // Create the function here to start the fight

            Console.ReadKey();
        }


       

        private static void AssignArmy(string[] ourPlatoonList, Army kingsArmy, Dictionary<string, int> kings)
        {

            foreach (var platoon in ourPlatoonList)
            {
                //Break the sequence with #
                string[] troopSize = platoon.Split("#");

                switch (troopSize[0])
                {
                    case "Militia":
                        kingsArmy.militia = new Militia();
                        kingsArmy.militia.numberOfSoldiers = Convert.ToInt32(troopSize[1]);
                        kings.Add("Militia", kingsArmy.militia.numberOfSoldiers);

                        Console.WriteLine("Soldiers in militia : {0}", kingsArmy.militia.numberOfSoldiers);
                        break;
                    case "CavalryArcher":
                        kingsArmy.cavalryArcher = new CavalryArcher();
                        kingsArmy.cavalryArcher.numberOfSoldiers = Convert.ToInt32(troopSize[1]);
                        kings.Add("CavalryArcher", kingsArmy.cavalryArcher.numberOfSoldiers);

                        Console.WriteLine("Soldiers in cavalryArcher : {0}", kingsArmy.cavalryArcher.numberOfSoldiers);
                        break;
                    case "FootArcher":
                        kingsArmy.footArcher = new FootArcher();
                        kingsArmy.footArcher.numberOfSoldiers = Convert.ToInt32(troopSize[1]);
                        kings.Add("FootArcher", kingsArmy.footArcher.numberOfSoldiers);

                        Console.WriteLine("Soldiers in footArcher : {0}", kingsArmy.footArcher.numberOfSoldiers);
                        break;
                    case "HeavyCavalry":
                        kingsArmy.heavyCavalry = new HeavyCavalry();
                        kingsArmy.heavyCavalry.numberOfSoldiers = Convert.ToInt32(troopSize[1]);
                        kings.Add("HeavyCavalry", kingsArmy.heavyCavalry.numberOfSoldiers);

                        Console.WriteLine("Soldiers in heavyCavalry : {0}", kingsArmy.heavyCavalry.numberOfSoldiers);
                        break;
                    case "LightCavalry":
                        kingsArmy.lightCavalry = new LightCavalry();
                        kingsArmy.lightCavalry.numberOfSoldiers = Convert.ToInt32(troopSize[1]);
                        kings.Add("LightCavalry", kingsArmy.lightCavalry.numberOfSoldiers);

                        Console.WriteLine("Soldiers in lightCavalry :  {0}", kingsArmy.lightCavalry.numberOfSoldiers);
                        break;
                    case "Spearmen":
                        kingsArmy.spearmen = new Spearmen();
                        kingsArmy.spearmen.numberOfSoldiers = Convert.ToInt32(troopSize[1]);
                        kings.Add("Spearmen", kingsArmy.spearmen.numberOfSoldiers);

                        Console.WriteLine("Soldiers in spearmen : {0}", kingsArmy.spearmen.numberOfSoldiers);
                        break;
                    default:
                        Console.WriteLine("No such army found");
                        break;
                }
            }
        }

        private static void AssignOpponentArmy(string[] ourPlatoonList, Army opponentArmy, Dictionary<string, int> opponent)
        {
            foreach (var platoon in ourPlatoonList)
            {
                //Break the sequence with #
                string[] troopSize = platoon.Split("#");

                switch (troopSize[0])
                {
                    case "Militia":
                        opponentArmy.militia = new Militia();
                        opponentArmy.militia.numberOfSoldiers = Convert.ToInt32(troopSize[1]);
                        opponent.Add("Militia", opponentArmy.militia.numberOfSoldiers);

                        Console.WriteLine("Soldiers in militia {0}", opponentArmy.militia.numberOfSoldiers);
                        break;
                    case "CavalryArcher":
                        opponentArmy.cavalryArcher = new CavalryArcher();
                        opponentArmy.cavalryArcher.numberOfSoldiers = Convert.ToInt32(troopSize[1]);
                        opponent.Add("CavalryArcher", opponentArmy.cavalryArcher.numberOfSoldiers);

                        Console.WriteLine("Soldiers in cavalryArcher {0}", opponentArmy.cavalryArcher.numberOfSoldiers);
                        break;
                    case "FootArcher":
                        opponentArmy.footArcher = new FootArcher();
                        opponentArmy.footArcher.numberOfSoldiers = Convert.ToInt32(troopSize[1]);
                        opponent.Add("FootArcher", opponentArmy.footArcher.numberOfSoldiers);

                        Console.WriteLine("Soldiers in footArcher {0}", opponentArmy.footArcher.numberOfSoldiers);
                        break;
                    case "HeavyCavalry":
                        opponentArmy.heavyCavalry = new HeavyCavalry();
                        opponentArmy.heavyCavalry.numberOfSoldiers = Convert.ToInt32(troopSize[1]);
                        opponent.Add("HeavyCavalry", opponentArmy.heavyCavalry.numberOfSoldiers);

                        Console.WriteLine("Soldiers in heavyCavalry {0}", opponentArmy.heavyCavalry.numberOfSoldiers);
                        break;
                    case "LightCavalry":
                        opponentArmy.lightCavalry = new LightCavalry();
                        opponentArmy.lightCavalry.numberOfSoldiers = Convert.ToInt32(troopSize[1]);
                        opponent.Add("LightCavalry", opponentArmy.lightCavalry.numberOfSoldiers);

                        Console.WriteLine("Soldiers in lightCavalry {0}", opponentArmy.lightCavalry.numberOfSoldiers);
                        break;
                    case "Spearmen":
                        opponentArmy.spearmen = new Spearmen();
                        opponentArmy.spearmen.numberOfSoldiers = Convert.ToInt32(troopSize[1]);
                        opponent.Add("Spearmen", opponentArmy.spearmen.numberOfSoldiers);

                        Console.WriteLine("Soldiers in spearmen {0}", opponentArmy.spearmen.numberOfSoldiers);
                        break;
                    default:
                        Console.WriteLine("No such army found");
                        break;
                }
            }
        }
    }
}
