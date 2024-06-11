using UnityEngine;

public class CubeMover : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private float _rotationSpeed = 50.0f;
    [SerializeField] private float _growSpeed = 0.09f;

    private void Update()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
        transform.localScale += Vector3.one * _growSpeed * Time.deltaTime;
    }
}