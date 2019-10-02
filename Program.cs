using System;

namespace klassen_high_score
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa highscoreklassen, max 5 i listan
            HighScore hs = new HighScore(5);
            
            // Fyll på med element
            hs.Add("BobbaFett", 132);
            hs.Add("ViktorAwsome", 120);
            hs.Add("HelenaMaster", 155);
            hs.Add("CodeCodeson", 40);
            hs.Add("CaptainMorgan", 110);
            
            // Gör testutskrift
            hs.Print();
            
            // Fyll på med mer element
            hs.Add("BobTabor", 35);
            hs.Add("BullTerrier", 112);
            
            // Ny testutskrift
            hs.Print();
        }
    }
}
