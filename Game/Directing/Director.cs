using System.Collections.Generic;
using cse210_04.Game.Casting;
using cse210_04.Game.Services;

namespace cse210_04.Game.Directing
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private KeyboardService _keyboardService = null;
        private VideoService _videoService = null;

        private static int COLS = 60;



        /// <summary>
        /// Constructs a new instance of Director using the given KeyboardService, VideoService, and ObjectFactory
        /// </summary>
        /// <param name="keyboardService">The given KeyboardService.</param>
        /// <param name="videoService">The given VideoService.</param>
        public Director(KeyboardService keyboardService, VideoService videoService)
        {
            this._keyboardService = keyboardService;
            this._videoService = videoService;
            ObjectFactory _objectFactory = new ObjectFactory();
        }

        /// <summary>
        /// Starts the game by running the main game loop for the given cast.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        public void StartGame(Cast cast)
        {
            _videoService.OpenWindow();
            while (_videoService.IsWindowOpen())
            {
                GetInputs(cast);
                DoUpdates(cast);
                DoOutputs(cast);
            }
            _videoService.CloseWindow();
        }

        /// <summary>
        /// Gets directional input from the keyboard and applies it to the minecart.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void GetInputs(Cast cast) // Dillon's job
        {
            Actor minecart = cast.GetFirstActor("minecart");
       

            Point velocity = _keyboardService.GetDirection();
            minecart.SetVelocity(velocity);     
        }

        /// <summary>
        /// Updates the minecart's position and resolves any collisions with artifacts.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void DoUpdates(Cast cast) // Emma and Andre
        {
            spawnFallingObjects();
            ScoreTracker scoretracker = (ScoreTracker)cast.GetFirstActor("banner");
            Actor scoreBanner = cast.GetFirstActor("banner");
            Actor multiplierBanner = cast.GetFirstActor("banner");

            Actor minecart = cast.GetFirstActor("minecart");
            List<Actor> fallingobjects = cast.GetActors("fallingObjects");

            int maxX = _videoService.GetWidth();
            int maxY = _videoService.GetHeight();
            minecart.MoveNext(maxX, maxY);
            // foreach(Actor actor in Fallingobjects){
            // Point setActorVel = _keyboardService.MoveArtifact();
            // }

            // Needs a way to make fallingobjects fall

            foreach (FallingObject actor in fallingobjects)
            {
                if (minecart.GetPosition().Equals(actor.GetPosition()))
                {
                    /// If player is in object position then 
                    /// call on Score Tracker UpdateScore()
                    scoretracker.UpdateMultiplier(actor.getMultiplier());
                    scoretracker.UpdateScore(actor.getPointValue());

                    string multiplierMessage = $"Multiplier: {scoretracker.GetMultiplier()}x";
                    multiplierBanner.SetText(multiplierMessage);
                    string scoreMessage = $"Score: {scoretracker.GetScore()}";
                    scoreBanner.SetText(scoreMessage);
                    cast.RemoveActor("fallingObjects", actor);
                }
                if (actor.GetPosition().GetY().Equals(0))
                {
                    cast.RemoveActor("fallingObjects", actor);
                }
            } 
        }

        /// <summary>
        /// Draws the actors on the screen.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        public void DoOutputs(Cast cast){ //Nathan
        //  display actors
        //   display score
        //    display multiplier
            List<Actor> actors = cast.GetAllActors();
            _videoService.ClearBuffer();
            _videoService.DrawActors(actors);
            _videoService.FlushBuffer();
        }

        private void spawnFallingObjects()
        {
            List<int> xList = new List<int>();
            for(int i = 0; i < 3; i++)
            {
                // no access to the random library
                int x = Random.Next(1, COLS).Except(xList);
                if (!xList.Contains(x))
                {
                    int y = _videoService.GetHeight();
                    Point position = new Point(x, y);
                    position = position.Scale(_videoService.GetCellSize());
                // no access to the random library
                    int objectType = Random.Next(1, 10);
                    _objectFactory.defineobject(objectType,position);
                    xList.Add(x);
                }
            }  
        }
    }
}
