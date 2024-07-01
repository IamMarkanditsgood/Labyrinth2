using UnityEngine;

public class Platform : MonoBehaviour
{
    private PlatformRotationManager _platformRotationManager = new();

    private void OnDestroy()
    {
        UnSubscribe();
    }

    public void Init()
    {
        _platformRotationManager.Init(gameObject);
        Subscribe();
    }
    
    private void Subscribe()
    {
        InputEvents.OnRotationDirectionChanged += _platformRotationManager.RotatePlatform;
    }
    private void UnSubscribe()
    {
        InputEvents.OnRotationDirectionChanged -= _platformRotationManager.RotatePlatform;
    }
}