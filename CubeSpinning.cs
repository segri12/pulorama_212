using UnityEngine;

public class CubeSpinning : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 50.0f;

    private void Update()
    {
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
    }
}