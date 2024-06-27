using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private float _rotationSpeed = 100f;
    [SerializeField] private float _maxRotationAngle = 45f;

    private Quaternion _initialRotation;

    private void Start()
    {
        _initialRotation = transform.rotation;
    }

    private void Update()
    {
        float horizontal = _joystick.Horizontal;
        float vertical = _joystick.Vertical;

        Vector3 rotation = new Vector3(-vertical * _rotationSpeed * Time.deltaTime, 0, horizontal * _rotationSpeed * Time.deltaTime);
        transform.Rotate(rotation);

        Vector3 currentEulerAngles = transform.localEulerAngles;

        currentEulerAngles.x = ClampAngle(currentEulerAngles.x, _initialRotation.eulerAngles.x - _maxRotationAngle, _initialRotation.eulerAngles.x + _maxRotationAngle);
        currentEulerAngles.z = ClampAngle(currentEulerAngles.z, _initialRotation.eulerAngles.z - _maxRotationAngle, _initialRotation.eulerAngles.z + _maxRotationAngle);

        currentEulerAngles.y = 0;

        transform.localEulerAngles = currentEulerAngles;
    }

    private float ClampAngle(float angle, float min, float max)
    {
        if (angle < 0f) angle += 360f;
        if (angle > 180f) angle -= 360f;
        return Mathf.Clamp(angle, min, max);
    }
}
