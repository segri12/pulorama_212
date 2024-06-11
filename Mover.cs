using UnityEngine;

public class Mover : MonoBehaviour
{
    private void Update()
    {
        var nextPositions = transform.position;
        nextPositions.z += 0.01f;
        transform.position = nextPositions;
    }
}
    