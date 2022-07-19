using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class GameData : MonoBehaviour
    {
        public static int score;
        public static float laserAmount = 10;
        private GameObject _label;
        public Text scoreText;
        public Text scoreText2;
        public static int _asteroidCounter;
        public static int _UFOCounter;
        private void Update()
        {
            scoreText.text = $"Score: {score}";
        }
        
        public static void ReloadScore()
        {
            score = 0;
            _UFOCounter = 0;
            _asteroidCounter = 0;
        }
    }
}