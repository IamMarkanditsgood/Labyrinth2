using Assets.Scripts.Entities.Ball;
using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "ScriptableObjects/LevelConfig", order = 1)]
public class LevelConfig : ScriptableObject
{
    [SerializeField] private GameLevels _gameLevel;
    [SerializeField] private Platform _platform;
    [SerializeField] private Ball _ball;
    [SerializeField] private Vector3 _platformSpawnPosition;
    [SerializeField] private Vector3 _ballSpawnPosition;
    
    public GameLevels GameLevel => _gameLevel;
    public Platform Platform => _platform;
    public Ball Ball => _ball;
    public Vector3 PlatformSpawnPosition => _platformSpawnPosition;
    public Vector3 BallSpawnPosition => _ballSpawnPosition;
}