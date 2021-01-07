using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 offset;

    void LateUpdate()
    {
        Vector3 newPos = target.position + offset;
        newPos.z = transform.position.z;
        transform.position = newPos;
    }
}
