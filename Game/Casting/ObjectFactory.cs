
    // create the falling objects
        private void createfallingobjects{
                for (int i = 0; i < DEFAULT_FALLING_OBJECTS; i++)
                {
                    string text = (
                    @" __
                    /||\
                    \||/
                     \/").ToString(); // <-- WHAT IS GOING TO BE THE SHAPE OF THE OBJECTS
                    string message = messages[i]; // <-- BASED ON THE MULTIPLIER : make sure it matches correctly

                    int x = random.Next(1, COLS);
                    int y = random.Next(1, ROWS);
                    Point position = new Point(x, y);
                    position = position.Scale(CELL_SIZE);

                    int r = random.Next(0, 256);
                    int g = random.Next(0, 256);
                    int b = random.Next(0, 256);
                    Color color = new Color(r, g, b);

                    Artifact artifact = new Artifact(); // <-- INSTANCE OF FALLING OBJECT
                    artifact.SetText(text); // <-- DEPENDING ON THE OBJECT
                    artifact.SetFontSize(FONT_SIZE);
                    artifact.SetColor(color);
                    artifact.SetPosition(position);
                    artifact.SetMessage(message); // <-- DEPENDING ON THE OBJECT
                    cast.AddActor("artifacts", artifact);
                }