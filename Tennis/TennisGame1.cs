namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private int _scorePlayer1 = 0;
        private int _scorePlayer2 = 0;
        private string _namePlayer1;
        private string _namePlayer2;

        public TennisGame1(string namePlayer1, string namePlayer2)
        {
            this._namePlayer1 = namePlayer1;
            this._namePlayer2 = namePlayer2;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
            {
                _scorePlayer1 += 1;
            }
            else
            {
                _scorePlayer2 += 1;
            }
        }

        public string GetScore()
        {
            var tennisScore = "";
            var tempScore = 0;
            if (_scorePlayer1 == _scorePlayer2)
            {
                tennisScore = Score.DisplayScore(_scorePlayer1, _scorePlayer2);
            }
            else if (_scorePlayer1 >= 4 || _scorePlayer2 >= 4)
            {
                var minusResult = _scorePlayer1 - _scorePlayer2;
                if (minusResult == 1)
                {
                    tennisScore = "Advantage player1";
                }
                else if (minusResult == -1)
                {
                    tennisScore = "Advantage player2";
                }
                else if (minusResult >= 2)
                {
                    tennisScore = "Win for player1";
                }
                else
                {
                    tennisScore = "Win for player2";
                }
            }
            else
            {
                tennisScore = Score.DisplayScore(_scorePlayer1, _scorePlayer2);
            }
            return tennisScore;
        }
    }
}