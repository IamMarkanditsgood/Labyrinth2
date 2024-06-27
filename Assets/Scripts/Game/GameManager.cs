using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Game
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private GameConfig _levelConfig;

        private LevelMaker _levelMaker = new();

        void Start()
        {
            _levelMaker.CreateLevel(_levelConfig);
        }
        void Update()
        {

        }
    }
    public class LevelMaker
    {
        public void CreateLevel(GameConfig levelConfig)
        {

        }
    }
}