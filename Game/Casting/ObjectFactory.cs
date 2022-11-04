using cse210_04.Game;
    // create the falling objects
    public class ObjectFactory{
        
        private string image;
        private int score;
        int muliplier;
        int fallingspeed;
        Color color;
        public void defineobject(int type){
            switch(type)
            {
            case 1:
                // rock
                int r = 228;
                int g = 166;
                int b = 24;
                Color color = new Color(r, g, b);
 
            break
            
            case 2 :
                // gem 
                // STANDARIZE OBJECT CHAR LENGTH TO EITHER 3 OR 5 CHARACTERS PLS
                // DIVIDE FONT SIZE (in Program class) BY THAT AMOUNT
                string text =(
                @" __
                /||\
                \||/
                    \/").ToString(); // <-- WHAT IS GOING TO BE THE SHAPE OF THE OBJECTS

                int r = 68;
                int g = 197;
                int b = 236;
                Color color = new Color(r, g, b);

            break
            
            case 3 :
            multiplier gem
            break
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
                cast.AddActor("fallingObjects", fallingObject);
            }
        }
    