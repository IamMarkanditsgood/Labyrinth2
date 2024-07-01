using Assets.Scripts.Game;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameConfig _gameConfig;
    [SerializeField] private GameLevels _currentLevel;

    [SerializeField] private LevelManager _levelManager;
    [SerializeField] private InputManager _inputManager;

    private LevelConfig _currentLevelConfig;

    private void Start()
    {
        InitGame();
    }

    private void Update()
    {
        _inputManager.CheckRotation();
    }
    private void InitGame()
    {
        _currentLevelConfig = _gameConfig.GetLevelConfig(_currentLevel);
        _levelManager.Init(_currentLevelConfig);
        _inputManager.Init(_gameConfig.InputSystem);
    }
}