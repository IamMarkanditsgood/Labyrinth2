using System;
using UnityEngine;

[Serializable]
public class LevelManager
{
    private LevelConfig _levelConfig;

    public void Init(LevelConfig levelConfig)
    { 
        _levelConfig = levelConfig;
        CreateScene(); 
    }

    private void CreateScene()
    {
        Platform platform;
        platform = UnityEngine.Object.Instantiate(_levelConfig.Platform, _levelConfig.PlatformSpawnPosition, Quaternion.identity);
        platform.Init();
    }
}