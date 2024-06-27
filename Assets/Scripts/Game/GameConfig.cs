using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "ScriptableObjects/LevelConfig", order = 1)]
public class GameConfig : ScriptableObject
{
    [SerializeField] private GameObject _platformPrefab;
    [SerializeField] private GameObject _ballPrefab;
    [SerializeField] private Vector3 _ballStartPos;
    [SerializeField] private Vector3 _platformStartPos;
    [SerializeField] private GameLevels _gameLevel;

}
