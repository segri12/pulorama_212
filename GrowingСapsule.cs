using UnityEngine;

public class GrowingCapsule : MonoBehaviour
{
    [SerializeField] private float _growSpeed = 0.09f;

    private void Update()
    {
        transform.localScale += Vector3.one * _growSpeed * Time.deltaTime;
    }
}