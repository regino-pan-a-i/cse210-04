using cse210_04.Game;
    // create the falling objects
    public class ObjectFactory{
        
        private string image;
        private int score;
        int multiplier;
        int fallingspeed;
        Color color;
        private string gemShape = (
                @" __
                /||\
                \||/
                    \/").ToString();
        private string rockShape = (
                @"_
            /-\
                \_/").ToString(); //makes the rock's shape


           
        private string multiplierGemShape = (
            @"    /\
   /__\
   \__/
    \/").ToString(); // the multiplier gem shape

        public void defineobject(int type){
            switch(type)
            {
            case 1:
                // Basic rock 
                image = rockShape;
                int r = 228;
                int g = 166;
                int b = 24;
                color = new Color(r, g, b);
                fallingspeed = 10;
                score = -250;
                multiplier = -1;
 
            break;

            break;
             case 2 :
             // tiny rock 
                image = rockShape;

                int r = 208;
                int g = 146;
                int b = 4;
                color = new Color(r, g, b);
                fallingspeed = 10;
                score = -100;
                multiplier = -1;
            break;

             case 3 :
             // little rock 
                image = rockShape;

                int r = 228;
                int g = 166;
                int b = 24;
                color = new Color(r, g, b);
                fallingspeed = 10;
                score = -500;
                multiplier = -1;
            break;

             case 4:
                // big rock 
                image = rockShape;
                int r = 228;
                int g = 166;
                int b = 24;
                color = new Color(r, g, b);
                fallingspeed = 10;
                score = -1000;
                multiplier = -1;
 
            break;
             case 4:
                // biggest rock 
                image = rockShape;
                int r = 255;
                int g = 255;
                int b = 150;
                color = new Color(r, g, b);
                fallingspeed = 10;
                score = -10000;
                multiplier = -1;
 
            break;
            
            case 6 :
                // gem basic
                image = gemShape;

                int r = 68;
                int g = 197;
                int b = 236;
                color = new Color(r, g, b);
                fallingspeed = 2;
                score = 100;
                multiplier = 0;
                
            break;
            case 7 :
                // gem mid
                image = gemShape;

                int r = 200;
                int g = 0;
                int b = 236;
                color = new Color(r, g, b);
                fallingspeed = 3;
                score = 500;
                multiplier = 0;
                
            break;
            case 8 :
                // gem high
                image = gemShape;

                int r = 200;
                int g = 0;
                int b = 0;
                color = new Color(r, g, b);
                fallingspeed = 5;
                score = 1000;
                multiplier = 0;
                
            break;
             case 9 :
                // gem low
                image = gemShape;

                int r = 68;
                int g = 197;
                int b = 236;
                color = new Color(r, g, b);
                fallingspeed = 1;
                score = 50;
                multiplier = 0;
                
            break;
            
            case 10 :
             // multiplier Gem
                image = multiplierGemShape;

                int r = 100;
                int g = 255;
                int b = 100;
                color = new Color(r, g, b);
                fallingspeed = 10;
                score = 100;
                multiplier = 1;
            break;
            }
            
            createobject ();
        }
        private void createobject()
        {

                FallingObject fallingObject = new FallingObject(); // <-- INSTANCE OF FALLING OBJECT
                fallingObject.SetText(text); // <-- DEPENDING ON THE OBJECT
                fallingObject.SetFontSize(FONT_SIZE);
                fallingObject.SetColor(color);
                fallingObject.SetPosition(position);
                fallingObject.setMultiplier(multiplier);
                fallingObject.setPointValue(score);
                fallingObject.SetVelocity(fallingspeed);
                cast.AddActor("fallingObjects", fallingObject);
        }
        }
    