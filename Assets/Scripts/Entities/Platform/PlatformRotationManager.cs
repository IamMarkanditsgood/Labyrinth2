using UnityEngine;

public class PlatformRotationManager
{
    [SerializeField] private float _rotationSpeed = 100f;
    [SerializeField] private float _maxRotationAngle = 45f;

    private GameObject _platform;
    private Quaternion _initialRotation;

    public void Init(GameObject platform)
    {
        _platform = platform;
        _initialRotation = _platform.transform.rotation;
    }

    public void RotatePlatform(Vector2 direction)
    {
      
        Vector3 rotation = new Vector3(-direction.y * _rotationSpeed * Time.deltaTime, 0, direction.x * _rotationSpeed * Time.deltaTime);
        _platform.transform.Rotate(rotation);

        Vector3 currentEulerAngles = _platform.transform.localEulerAngles;

        currentEulerAngles.x = ClampAngle(currentEulerAngles.x, _initialRotation.eulerAngles.x - _maxRotationAngle, _initialRotation.eulerAngles.x + _maxRotationAngle);
        currentEulerAngles.z = ClampAngle(currentEulerAngles.z, _initialRotation.eulerAngles.z - _maxRotationAngle, _initialRotation.eulerAngles.z + _maxRotationAngle);

        currentEulerAngles.y = 0;

        _platform.transform.localEulerAngles = currentEulerAngles;
    }
    private float ClampAngle(float angle, float min, float max)
    {
        if (angle < 0f) angle += 360f;
        if (angle > 180f) angle -= 360f;
        return Mathf.Clamp(angle, min, max);
    }
}