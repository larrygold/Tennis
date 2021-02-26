namespace Tennis
{
    public class TennisGame1 : ITennisGame
    {
        public Player _player1 { get; }
        public Player _player2 { get; }
        private readonly ScoreManager _scoreManager;

        public TennisGame1(string namePlayer1, string namePlayer2)
        {
            _player1 = new Player(namePlayer1);
            _player2 = new Player(namePlayer2);
            _scoreManager = new ScoreManager(this);
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
            {
                _player1.AddPoint();
            }
            else
            {
                _player2.AddPoint();
            }
        }

        public string GetScore()
        {
            return _scoreManager.DisplayScore(_player1.Score, _player2.Score);
        }
    }
}