using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderUC
{
    public static class SnakLadder
    {
        public static void playGame()
        { 
            
            int win = 0;
            int[] player = {0,0};

            int[] playDice = { 0, 0 };
            int diceRoll, arrayIndex;

            Random random = new Random();
            string[] choiceArray = {"noPlay","ladder","snake" };

            int turn = 0;

            while (player[0]<100 && player[1]<100)
            {
                Console.WriteLine("\n Player" + (turn+1) + "is playing");
                Console.WriteLine("Player" + (turn + 1) + "position is : " + player[turn]);

                diceRoll = random.Next(1,7);
                playDice[turn]++;

                Console.WriteLine("Player" + (turn + 1) + "dice roll are : " + player[turn]);
                Console.WriteLine("Number appear on dice is:" + diceRoll);

                arrayIndex=random.Next(choiceArray.Length);
                Console.WriteLine("Player Option is:" + choiceArray[arrayIndex]);

                if (choiceArray[arrayIndex] == "noPlay" && turn == 0)
                {
                    turn = 1;
                    continue;
                }
                else if (choiceArray[arrayIndex]=="noPlay" && turn==1)
                {
                    turn = 0;
                    continue;
                }
                if (choiceArray[arrayIndex]=="ladder")
                {
                    if ((player[turn]+diceRoll) >=100)
                    {
                        player[turn] = 100;
                        win = turn;
                    }
                    else
                    {
                        player[turn]+=diceRoll;
                        continue;
                    }
                }
                else if (choiceArray[arrayIndex]=="snake")
                {
                    if (player[turn]<diceRoll)
                    {
                        player[turn] = 0;
                    }
                    else
                    {
                        player[turn]-=diceRoll;
                    }
                }
                if (player[0]==100 || player[1]==100)
                {
                    win = turn;
                    break;
                }
                if(turn==0)
                {
                    turn = 1;
                }
                else
                {
                    turn = 0;
                }
                Console.WriteLine("Winner Player is :" + (win+1) );
                Console.WriteLine("Player Position is :" + player[win] );
            }

        }
    }
}
