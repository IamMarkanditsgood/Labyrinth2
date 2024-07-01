using UnityEngine;

namespace Assets.Scripts.Game
{
    [CreateAssetMenu(fileName = "GameConfig", menuName = "ScriptableObjects/GameConfig", order = 1)]
    public class GameConfig : ScriptableObject
    {
        [SerializeField] private LevelConfig[] _levels;
        [SerializeField] private InputSystems _inputSystem;

        public InputSystems InputSystem => _inputSystem;

        public LevelConfig GetLevelConfig(GameLevels currentLevel)
        {
            for(int i = 0; i < _levels.Length; i++)
            {
                if(currentLevel == _levels[i].GameLevel)
                {
                    return _levels[i]; 
                }
            }
            return null;
        }

    }
}