using Assets.Scripts.Game;
using System;
using UnityEngine;

[Serializable]
public class InputManager
{
    [SerializeField] private FixedJoystick _joystick;

    private InputSystems _currentInputSystem;
    private Vector2 _previousRotationDirection;

    public void Init(InputSystems currentInputSystem)
    {
        _currentInputSystem = currentInputSystem;
        _previousRotationDirection = Vector2.zero;
    }
    public void CheckRotation()
    {
        switch(_currentInputSystem)
        {
            case InputSystems.Accelerometer:
                CheckAccelerometer();
                break;
            case InputSystems.Joystick:
                CheckJoystick();
               break;
        }
    }

    private void CheckAccelerometer()
    {
        //TODO
    }

    private void CheckJoystick()
    {
        float horizontal = _joystick.Horizontal;
        float vertical = _joystick.Vertical;
        Vector2 direction = new Vector2(horizontal, vertical);
        if(IsInputted(direction))
        {
            InputEvents.ChangeRotationDirection(direction);
        }
    }
    
    private bool IsInputted(Vector2 direction)
    {
        
        if (direction != _previousRotationDirection)
        {
            return true;
        }
        return false;
    }
}