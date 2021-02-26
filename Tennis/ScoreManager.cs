using System;
using System.Collections.Generic;
using System.Text;

namespace Tennis
{
    public class ScoreManager
    {
        public TennisGame1 Game { get; }

        public ScoreManager(TennisGame1 game)
        {
            Game = game;
        }

        public string DisplayScore(int numericScorePlayer1, int numericScorePlayer2)
        {

            if (numericScorePlayer1 == numericScorePlayer2)
            {
                return DisplayScoresIfEqual(numericScorePlayer1);
            }

            if (numericScorePlayer1 >= 4 || numericScorePlayer2 >= 4)
            {
                return DisplayScoreIfAnyPlayerReachesFourPoints(numericScorePlayer1, numericScorePlayer2);
            }

            return DisplayScoreIfDifferent(numericScorePlayer1, numericScorePlayer2);

        }

        private string DisplayScoreIfAnyPlayerReachesFourPoints(int score1, int score2)
        {
            var scoreDelta = score1 - score2;

            if (scoreDelta >= 2)
            {
                return $"Win for {Game._player1.Name}";
            }

            switch (scoreDelta)
            {
                case 1:
                    return  $"Advantage {Game._player1.Name}";
                case -1:
                    return $"Advantage {Game._player2.Name}";
            }

            return $"Win for {Game._player2.Name}";
        }

        private static string DisplayScoresIfEqual(int score)
        {
            switch (score)
            {
                case 0:
                case 1:
                case 2:
                    return $"{ConvertScore(score)}-All";
                default:
                    return TennisScores.Deuce.ToString();
            }
        }

        private static string DisplayScoreIfDifferent(int score1, int score2)
        {
            var tennisScoreDisplayed = new StringBuilder();
            tennisScoreDisplayed.Append(ConvertScore(score1)).Append("-").Append(ConvertScore(score2));
            return tennisScoreDisplayed.ToString();
        }

        private static string ConvertScore(int numericScore)
        {
            switch (numericScore)
            {
                case 0:
                    return TennisScores.Love.ToString();

                case 1:
                    return TennisScores.Fifteen.ToString();

                case 2:
                    return TennisScores.Thirty.ToString();

                case 3:
                    return TennisScores.Forty.ToString();

                default:
                    throw new ArgumentOutOfRangeException("The numeric score is not among the allowed values");

            }
        }

    }
}
