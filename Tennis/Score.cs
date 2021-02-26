using System;
using System.Collections.Generic;
using System.Text;

namespace Tennis
{
    public static class Score
    {
        public static string DisplayScore(int numericScorePlayer1, int numericScorePlayer2)
        {
            if (numericScorePlayer1 == 4 || numericScorePlayer2 == 4)
            {
                DisplayScoreIfAnyPlayerReachesForty(numericScorePlayer1, numericScorePlayer2);
            }

            if (numericScorePlayer1 == numericScorePlayer2)
            {
                return DisplayEqualScores(numericScorePlayer1);
            }

            return DisplayDifferentScores(numericScorePlayer1, numericScorePlayer2);

        }

        private static string DisplayScoreIfAnyPlayerReachesForty(int score1, int score2)
        {
            var scoreDelta = score1 - score2;

            if (scoreDelta == 1)
            {
                return  "Advantage player1";
            }

            if (scoreDelta == -1)
            {
                return "Advantage player2";
            }

            if (scoreDelta >= 2)
            {
                return "Win for player1";
            }

            return "Win for player2";

        }

        private static string DisplayEqualScores(int score)
        {
            switch (score)
            {
                case 0:
                    return "Love-All";
                case 1:
                    return "Fifteen-All";
                case 2:
                    return "Thirty-All";
                default:
                    return "Deuce";
            }

        }

        private static string DisplayDifferentScores(int score1, int score2)
        {
            var tennisScoreDisplayed = "";
            tennisScoreDisplayed += ConvertScore(score1);
            tennisScoreDisplayed += "-";
            tennisScoreDisplayed += ConvertScore(score2);
            return tennisScoreDisplayed;
        }

        private static string ConvertScore(int numericScore)
        {
            switch (numericScore)
            {
                case 0:
                    return "Love";

                case 1:
                    return "Fifteen";

                case 2:
                    return "Thirty";

                case 3:
                    return "Forty";

                default:
                    throw new ArgumentOutOfRangeException("The numeric score is not in the allowed values");

            }
        }
    }
}
