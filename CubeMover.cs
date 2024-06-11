using UnityEngine;

public class CubeMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _growSpeed;

    private void Update()
    {
        var nextPositions = transform.position;
        nextPositions += transform.forward * _speed * Time.deltaTime;
        transform.position = nextPositions;

        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);

        var nextScale = transform.localScale;
        nextScale.x += _growSpeed * Time.deltaTime;
        nextScale.y += _growSpeed * Time.deltaTime;
        nextScale.z += _growSpeed * Time.deltaTime;
        transform.localScale = nextScale;
    }
}