using System;
using UnityEngine;

public static class InputEvents
{
    public static event Action<Vector2> OnRotationDirectionChanged;

    public static void ChangeRotationDirection(Vector2 direction)
    {
        
        OnRotationDirectionChanged?.Invoke(direction);
    }
}