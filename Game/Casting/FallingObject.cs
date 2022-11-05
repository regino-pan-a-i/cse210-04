//class8: FallingObject, child to actor --
    //-responsibility: falls, has point value, has symbol
    //-attributes: point values for R & G, symbols
    //-Methods: int GetPoints(); void SetPoints();


using System;

namespace cse210_04.Game.Casting;
    
    public class fallingObject : Actor {
        private int multiplier;
        private int score;
        
        // Random random = new Random();
        // private List<int> positive_values = new List<int>() [10, 100, 5, 50]; // if its still angry use {} 
        // private List<int> negative_values = new List<int>() [-10 ,-100, -5, -50]; 
        // private int gem_values =  random.Next(positive_values);
        // private int rock_values = random.Next(negative_values);

        public int getPoint(){
            return value;
        }

        }

        //
        public setPointValue(int pointValue){
            score = pointValue;
        }
        public setMultiplier(int Multiplier)
        {
            multiplier = M0ultiplier;
        }
        
    