using System;
using System.Collections.Generic;
using System.Text;

namespace Ajira.ProblemOfKing
{
    public class BattleFormation
    {
        public static string StartingBattleFormationAnalysis(Dictionary<string, int> kings, Dictionary<string, int> opponent)
        {
            //Pick any of the item from kings dictionary 
            // compare it with opponent dictionary 
            // if king is able to win, calculate its win score
            // if kings looses calcute its loose score 
            // win score should be 60 % or win score should be 3
            StringBuilder outputPlatoonFormation = new StringBuilder();

            int win = 0;
            int newWin = 0;


                foreach (var kingBattleTroop in kings)
                {
                    var troopType = kingBattleTroop.Key;
                    var troopCount = kingBattleTroop.Value;

                    if (troopType == "Spearmen")
                    {
                        if (opponent.ContainsKey("Spearmen"))
                        {
                            var spearmenCount = opponent["Spearmen"];
                            if (troopCount > spearmenCount)
                            {
                                newWin += 1;
                                outputPlatoonFormation.Append(troopType + "#" + troopCount + ";");
                                continue;
                            }

                        }
                        if (opponent.ContainsKey("LightCavalry"))
                        {
                            var lightCavalaryCount = opponent["LightCavalry"];
                            if (troopCount * 2 > lightCavalaryCount)
                            {
                                newWin += 1;
                                outputPlatoonFormation.Append(troopType + "#" + troopCount + ";");
                                continue;
                            }

                        }

                        if (opponent.ContainsKey("HeavyCavalry"))
                        {
                            var heavyCavalryCount = opponent["HeavyCavalry"];
                            if (troopCount > heavyCavalryCount || troopCount * 2 > heavyCavalryCount)
                            {
                                newWin += 1;
                                outputPlatoonFormation.Append(troopType + "#" + troopCount + ";");
                                continue;
                            }

                        }
                    }

                    if (troopType == "Militia")
                    {
                        if (opponent.ContainsKey("Militia"))
                        {
                            var militiaCount = opponent["Militia"];
                            if (troopCount > militiaCount)
                            {
                                newWin += 1;
                                outputPlatoonFormation.Append(troopType + "#" + troopCount + ";");
                                continue;
                            }

                        }
                        if (opponent.ContainsKey("Spearmen"))
                        {
                            var spearmenCount = opponent["Spearmen"];
                            if (troopCount > spearmenCount || troopCount * 2 > spearmenCount)
                            {
                                newWin += 1;
                                outputPlatoonFormation.Append(troopType + "#" + troopCount + ";");
                                continue;
                            }

                        }
                        if (opponent.ContainsKey("LightCavalry"))
                        {
                            var lightCavalryCount = opponent["LightCavalry"];
                            if (troopCount > lightCavalryCount || troopCount * 2 > lightCavalryCount)
                            {
                                newWin += 1;
                                outputPlatoonFormation.Append(troopType + "#" + troopCount + ";");
                                continue;
                            }

                        }
                    }

                    if (troopType == "LightCavalry")
                    {
                        if (opponent.ContainsKey("LightCavalry"))
                        {
                            var lightCavalryCount = opponent["LightCavalry"];
                            if (troopCount > lightCavalryCount)
                            {
                                newWin += 1;
                                outputPlatoonFormation.Append(troopType + "#" + troopCount + ";");
                                continue;
                            }

                        }
                        if (opponent.ContainsKey("FootArcher"))
                        {
                            var footArcherCount = opponent["FootArcher"];
                            if (troopCount > footArcherCount || troopCount * 2 > footArcherCount)
                            {
                                newWin += 1;
                                outputPlatoonFormation.Append(troopType + "#" + troopCount + ";");
                                continue;
                            }

                        }
                        if (opponent.ContainsKey("CavalryArcher"))
                        {
                            var cavalryArcherCount = opponent["CavalryArcher"];
                            if (troopCount > cavalryArcherCount || troopCount * 2 > cavalryArcherCount)
                            {
                                newWin += 1;
                                outputPlatoonFormation.Append(troopType + "#" + troopCount + ";");
                                continue;
                            }

                        }
                    }

                    if (troopType == "HeavyCavalry")
                    {
                        if (opponent.ContainsKey("HeavyCavalry"))
                        {
                            var heavyCavalryCount = opponent["HeavyCavalry"];
                            if (troopCount > heavyCavalryCount)
                            {
                                newWin += 1;
                                outputPlatoonFormation.Append(troopType + "#" + troopCount + ";");
                                continue;
                            }

                        }
                        if (opponent.ContainsKey("Militia"))
                        {
                            var militiaCount = opponent["Militia"];
                            if (troopCount > militiaCount || troopCount * 2 > militiaCount)
                            {
                                newWin += 1;
                                outputPlatoonFormation.Append(troopType + "#" + troopCount + ";");
                                continue;
                            }

                        }
                        if (opponent.ContainsKey("FootArcher"))
                        {
                            var footArcherCount = opponent["FootArcher"];
                            if (troopCount > footArcherCount || troopCount * 2 > footArcherCount)
                            {
                                newWin += 1;
                                outputPlatoonFormation.Append(troopType + "#" + troopCount + ";");
                                continue;
                            }

                        }
                        if (opponent.ContainsKey("LightCavalry"))
                        {
                            var lightCavalryCount = opponent["LightCavalry"];
                            if (troopCount > lightCavalryCount || troopCount * 2 > lightCavalryCount)
                            {
                                newWin += 1;
                                outputPlatoonFormation.Append(troopType + "#" + troopCount + ";");
                                continue;
                            }

                        }
                    }

                    if (troopType == "CavalryArcher")
                    {
                        if (opponent.ContainsKey("CavalryArcher"))
                        {
                            var cavalryArcherCount = opponent["CavalryArcher"];
                            if (troopCount > cavalryArcherCount)
                            {
                                newWin += 1;
                                outputPlatoonFormation.Append(troopType + "#" + troopCount + ";");
                                continue;
                            }

                        }
                        if (opponent.ContainsKey("Spearmen"))
                        {
                            var spearmenCount = opponent["Spearmen"];
                            if (troopCount > spearmenCount || troopCount * 2 > spearmenCount)
                            {
                                newWin += 1;
                                outputPlatoonFormation.Append(troopType + "#" + troopCount + ";");
                                continue;
                            }

                        }
                        if (opponent.ContainsKey("HeavyCavalry"))
                        {
                            var heavyCavalryCount = opponent["HeavyCavalry"];
                            if (troopCount > heavyCavalryCount || troopCount * 2 > heavyCavalryCount)
                            {
                                newWin += 1;
                                outputPlatoonFormation.Append(troopType + "#" + troopCount + ";");
                                continue;
                            }

                        }
                    }

                    if (troopType == "FootArcher")
                    {
                        if (opponent.ContainsKey("FootArcher"))
                        {
                            var footArcherCount = opponent["FootArcher"];
                            if (troopCount > footArcherCount)
                            {
                                newWin += 1;
                                outputPlatoonFormation.Append(troopType + "#" + troopCount + ";");
                                continue;
                            }

                        }
                        if (opponent.ContainsKey("Militia"))
                        {
                            var militiaCount = opponent["Militia"];
                            if (troopCount > militiaCount || troopCount * 2 > militiaCount)
                            {
                                newWin += 1;
                                outputPlatoonFormation.Append(troopType + "#" + troopCount + ";");
                                continue;
                            }

                        }
                        if (opponent.ContainsKey("CavalryArcher"))
                        {
                            var cavalryArcherCount = opponent["CavalryArcher"];
                            if (troopCount > cavalryArcherCount || troopCount * 2 > cavalryArcherCount)
                            {
                                newWin += 1;
                                outputPlatoonFormation.Append(troopType + "#" + troopCount + ";");
                                continue;
                            }

                        }
                    }
                }

            if (newWin < 3)
            {
                return "There is no chance of winning";
            }

            return outputPlatoonFormation.ToString();


        }
    }
}
