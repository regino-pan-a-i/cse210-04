// Class9: ScoreTracker -- Madison
//     -responsibilty: track score, track multiplier, update the score
//     -attributes: score, multiplier
//     -methods: int GetScore, int GetMultiplier, int UpdateScore(score), int UpdateMultiplier

namespace Unit04.Game.Casting;
public class ScoreTracker
{
    // Initializing Score and Multiplier Variables
    private int Score = 0;
    private int Multiplier = 1;

    // Method GetScore:
    // Responsiblity: Getter for the current score
    // Parameters: None
    // Returns: Score
    private int GetScore()
    {
        return Score;
    }
    // Method GetMultiplier:
    // Responsiblity: Getter for the current multiplier
    // Parameters: None
    // Returns: Multiplier
    private int GetMultiplier()
    {
        return Multiplier;
    }
    // Method UpdateScore:
    // Responsibility: Determines the new score based on the hit item's point value and the current multiplier.
    // Parameters: ItemScore: point value of the hit item
    // Returns: None
    private void UpdateScore(int ItemScore)
    {
        Score += (ItemScore * Multiplier);
    }
    // Method UpdateMultiplier:
    // Responsibility: Determines the new multiplier based on the hit item's multiplier value.
    // Parameters: ItemMultiplier: point value of the hit item
    // Returns: None
    private void UpdateMultiplier(int ItemMultiplier)
    {
        if (ItemMultiplier == -1)
        {
            Multiplier = 1;
        }
        else
        {
            Multiplier += ItemMultiplier;
        }
    }
}