# cse210-04: Greed

Greed is played according to the following rules:

- Gems (*) and rocks (o) randomly appear and fall from the top of the screen.
- The player (#) can move left or right along the bottom of the screen.
- If the player touches a gem they earn a point.
- If the player touches a rock they lose a point.
- Gems and rocks are removed when the player touches them.
- The game continues until the player closes the window.

# Getting Started:
Make sure you have dotnet 6.0 or newer installed on your machine. Open a terminal and browse to the project's root folder. Start the program by running the following commands:

dotnet add package raylib-cs
dotnet build 
dotnet run

# Project Structure:
The project files and folders are organized as follows:
* Directing
    - Director
* Services
    - KeyboardServices
    - videoService
* Casting
    - Actor(stores info and methods about a actor in the game)
    - Cast(stores all of the actors made throughout the game)
    - Color(stores colors for the rest of the game)
    - FallingObject(methods for the gem/rock/multiplier falling)
    - ObjectFactory(creator of falling objects)
    - Point(tracks the location of a thing)
    - ScoreTracker(child of actor, works with the score)

# Authors:
* Dillon Leone
* Andre Regino
* Emma Quackenbush
* Nathan Marble
* Justin Paystrup
* Madison Brown

