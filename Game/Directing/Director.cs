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

        /// <summary>
        /// Constructs a new instance of Director using the given KeyboardService and VideoService.
        /// </summary>
        /// <param name="keyboardService">The given KeyboardService.</param>
        /// <param name="videoService">The given VideoService.</param>
        public Director(KeyboardService keyboardService, VideoService videoService)
        {
            this._keyboardService = keyboardService;
            this._videoService = videoService;
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
            foreach(Actor actor in Fallingobjects){
                Point setActorVel = _keyboardService.MoveArtifact();
            }


            Point velocity = _keyboardService.GetDirection();
            minecart.SetVelocity(velocity);     
        }

        /// <summary>
        /// Updates the minecart's position and resolves any collisions with artifacts.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void DoUpdates(Cast cast) // Emma and Andre
        {
            
            ScoreTracker scoretracker = (ScoreTracker)cast.GetFirstActor("banner");
            Actor scoreBanner = cast.GetFirstActor("banner");
            Actor multiplierBanner = cast.GetFirstActor("banner");

            Actor minecart = cast.GetFirstActor("minecart");
            List<Actor> artifacts = cast.GetActors("artifacts");

            banner.SetText("");
            int maxX = _videoService.GetWidth();
            int maxY = _videoService.GetHeight();
            minecart.MoveNext(maxX, maxY);

            foreach (Actor actor in artifacts)
            {
                if (minecart.GetPosition().Equals(actor.GetPosition()))
                {
                    /// If player is in object position then 
                    /// call on Score Tracker UpdateScore()
                    scoretracker.UpdateMultiplier();
                    scoretracker.UpdateScore();
                    string multiplierMessage = $"Multiplier: {scoretracker.GetMultiplier()}x";
                    banner.SetText(multiplerMessage);
                    string scoreMessage = $"Score: {scoretracker.GetScore()}";
                    banner.SetText(scoreMessage);

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

    }
}