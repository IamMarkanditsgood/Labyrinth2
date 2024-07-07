using Assets.Scripts.Entities.Ball;
using System;
using UnityEngine;

[Serializable]
public class LevelManager
{
    private LevelConfig _levelConfig;
    private SceneMaker sceneMaker = new();

    public void Init(LevelConfig levelConfig)
    { 
        _levelConfig = levelConfig;
        sceneMaker.CreateScene(levelConfig); 
    }
}

public class SceneMaker
{
    public void CreateScene(LevelConfig levelConfig)
    {
        CreatePlatform(levelConfig);
        CreateBall(levelConfig);
    }

    private void CreatePlatform(LevelConfig levelConfig)
    {
        IInitializable platform;
        platform = UnityEngine.Object.Instantiate(levelConfig.Platform, levelConfig.PlatformSpawnPosition, Quaternion.identity);
        platform.Init();
    }
    private void CreateBall(LevelConfig levelConfig)
    {
        IInitializable ball;
        ball = UnityEngine.Object.Instantiate(levelConfig.Ball, levelConfig.BallSpawnPosition, Quaternion.identity);
        ball.Init();
    }
}