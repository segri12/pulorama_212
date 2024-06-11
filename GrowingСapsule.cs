using UnityEngine;

public class Growing�apsule : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        var nextScale = transform.localScale;
        nextScale.x += _speed * Time.deltaTime;
        nextScale.y += _speed * Time.deltaTime;
        nextScale.z += _speed * Time.deltaTime;
        transform.localScale = nextScale;
    }
}
