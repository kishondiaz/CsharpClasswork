using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class ScoreSheet
    {
        Die[] dieArray;
        public enum ScoreItems
        {
            Dummy,Aces,Twos,Three,Fours,Five,Sixes,SubTotalUpper,Bouns,TotalUpper
        }
        public int[] possibleScores = new int[22];
        public int[] actualScore = new int[22];

        public ScoreSheet(Die[] dieArray)
        {
            this.dieArray = dieArray;
        }

        public void updateScoreSheet()
        {
            //Scoring Aces

            for (int i = 1; i < 6; i++)
            {
                if (dieArray[i].Value == 1) possibleScores[(int)ScoreItems.Aces]+=1;
                if (dieArray[i].Value == 2) possibleScores[(int)ScoreItems.Twos] += 2;
                if (dieArray[i].Value == 3) possibleScores[(int)ScoreItems.Three] += 3;
                if (dieArray[i].Value == 4) possibleScores[(int)ScoreItems.Fours] += 4;
                if (dieArray[i].Value == 5) possibleScores[(int)ScoreItems.Five] += 5;
                if (dieArray[i].Value == 6) possibleScores[(int)ScoreItems.Sixes] += 6;
             

            }

            int subtotal = 0;
            for (int i = Convert.ToInt16(ScoreItems.Aces); i < Convert.ToInt16(ScoreItems.Sixes); i++)
            {
                subtotal += possibleScores[i];
            }
            possibleScores[Convert.ToInt16(ScoreItems.SubTotalUpper)] = subtotal;

            if (possibleScores[Convert.ToInt16(ScoreItems.SubTotalUpper)] >= 63)
            {
                possibleScores[Convert.ToInt16(ScoreItems.Bouns)] = 35;
            }
            possibleScores[Convert.ToInt16(ScoreItems.TotalUpper)] = possibleScores[Convert.ToInt16(ScoreItems.SubTotalUpper)] + possibleScores[Convert.ToInt16(ScoreItems.Bouns)];
            
        }
        /*private int PossibleScores(ScoreItems scoreitem)
        {
            int subtotal = 0;
            for (int i = (int)scoreitem; i < (int)scoreitem; i++)
            {
                subtotal += possibleScores[i];
            }
            possibleScores[(int)scoreitem] = subtotal;

            if (possibleScores[(int)ScoreItems.SubTotalUpper] >= 63)
            {
                possibleScores[(int)ScoreItems.Bouns] = 35;
            }
            return possibleScores[(int)ScoreItems.TotalUpper] = possibleScores[(int)ScoreItems.SubTotalUpper] + possibleScores[(int)ScoreItems.Bouns];
        }*/
    }

    
}
