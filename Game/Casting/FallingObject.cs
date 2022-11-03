//class8: FallingObject, child to actor --
    //-responsibility: falls, has point value, has symbol
    //-attributes: point values for R & G, symbols
    //-Methods: int GetPoints(); void SetPoints();


using System;

namespace cse210_04.Game.Casting;
    
    public class fallingObject : Actor {

        Random random = new Random();
        private List<int> positive_values = [10, 100, 5, 50];  
        private List<int> negative_values = [-10 ,-100, -5, -50]; 
        private int gem_values =  random.Next(positive_values);
        private int rock_values = random.Next(negative_values);
        private static int DEFAULT_FALLING_OBJECTS = 40;

        public int getPoint(){
            return value;
        }

        }
    }



