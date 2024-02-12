using UnityEngine;

namespace Platformer
{
    public class PlayerScore : MonoBehaviour
    {
        private int _score;
        private float _timer;

        public int Score
        {
            get { return _score; }
            private set
            {
                if (value < 0)
                {
                    _score = 0;
                }
                else
                {
                    _score = value;
                }
            }
        }

        public void IncreaseScore(int increment)
        {
            Score += increment;
        }

        private void Start()
        {
            // Initialize score
            Score = 0;
        }

        private void Update()
        {
            // Increase score every second
            _timer += Time.deltaTime;
            if (_timer >= 1f)
            {
                IncreaseScore(1);
                _timer -= 1f;
            }
            Debug.Log(Score);
        }
    }
}