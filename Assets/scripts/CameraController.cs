using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    private void LateUpdate()
    {
        transform.position = new Vector3(target.position.x +0.7f, transform.position.y, transform.position.z);
    }

}
