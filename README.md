# cse210-04: Greed

"I anticipate... some problems." - Bro. Manley
"Thank you, Robot finds kitten. You have changed my life."
"Me likey SDL2. It's worthy."
Goal of the class is to learn how to make code that is easy to maintain
3 inheritance links max
Favor composition over inheritance!!

Greed is played according to the following rules:

Gems (*) and rocks (o) randomly appear and fall from the top of the screen.
The player (#) can move left or right along the bottom of the screen.
If the player touches a gem they earn a point.
If the player touches a rock they lose a point.
Gems and rocks are removed when the player touches them.
The game continues until the player closes the window.


Your program must also meet the following requirements:

The program must have a README file.
The program must have at least eight classes.
Each module, class and method must have a corresponding comment.
The game must remain generally true to the order of play described earlier.

class7: Director-- Emma/Andre
    -responsibility: Direct traffic
    -attributes: overall score
    -Methods: GetInputs: -- Dillon
                -right/left
              DoUpdates: -- Andre/Emma
                -create rock/gem 
                    -random position on screen
                    -set point value
                    -set color
                    -
                -WhatsHit(is player in rock/gem)
                    -(determine if object is hit) if true call on Update score
                    -return point value
                -Update position
                -update score
                    -call on player method passing ture/false
                -get rid of object
              DoOutputs-- Nathan
                - display actors
                - display score
                - display multiplier

class8: FallingObject, child to actor -- Justin
    -responsibility: falls, has point value, has symbol
    -attributes: point values for R & G, symbols
    -Methods: int GetPoints(); void SetPoints();

Class9: ScoreTracker -- Madison
    -responsibilty: track score, track multiplier, update the score
    -attributes: score, multiplier
    -methods: int GetScore, int GetMultiplier, int UpdateScore(score, multiplier), int UpdateMultiplier

!!dotnet add package raylib-cs!!