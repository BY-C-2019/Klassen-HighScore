using System;
using System.Collections.Generic;

namespace klassen_high_score
{
    class HSItem
    {
        private string name;
        public string Name {get { return name; } set { name = value; }}
       
        private int points;
        public int Points {get { return points; } set { points = value; }}

        public HSItem(string name, int points)
        {
            this.name   = name;
            this.points = points;
        }
    }

    class HighScore
    {
        private int             maxInList;
        private List<HSItem>    highScoreList = new List<HSItem>();

        public HighScore(int maxInList)
        {
            this.maxInList = maxInList;
        }

        public void Add(string name, int points)
        {
            // If there's no more empty spots
            if (highScoreList.Count == maxInList) {

                // Check if highscore is lower than current lowest score, if yes return out of function
                if (points < highScoreList[highScoreList.Count-1].Points) {
                       return;
                   }
            
                // Remove current lowest highscore and add the new on to the list
                highScoreList.RemoveAt(highScoreList.Count-1);
                highScoreList.Add(new HSItem(name, points));
                
            }

            // If there's empty spots, add highscore straight away
            else if (highScoreList.Count < maxInList) {
                highScoreList.Add(new HSItem(name, points));
            }

            // If a new highscore was added to the list, re-sort it.
            Sort();
        }

        public void Print()
        {
            Console.WriteLine("--- HIGH SCORE ------------------");
            for (int i = 0; i < highScoreList.Count; i++)
            {
                Console.WriteLine("{0}. {1} - {2}", i+1, highScoreList[i].Name, highScoreList[i].Points); 
            }
            Console.WriteLine("---------------------------------\n");
        }
        
        private void Sort()
        {
            // Bubblesort algoritm
            for (int i = 0; i < highScoreList.Count - 1; i++)
            {
                for (int j = 0; j < highScoreList.Count - 1 - i; j++)
                {
                    if (highScoreList[j].Points > highScoreList[j + 1].Points)
                    {
                        HSItem temp = highScoreList[j + 1];
                        highScoreList[j + 1] = highScoreList[j];
                        highScoreList[j] = temp;
                    }
                }
            }
            // Reverse list to get highest score first
            highScoreList.Reverse();
        }
    }
}
