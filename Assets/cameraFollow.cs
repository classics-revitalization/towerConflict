using UnityEngine;

public class cameraFollow : MonoBehaviour
{

    public Transform target;

    public float smoothSpeed; = 0.150f;

    void LateUpdate ()
    {
        transform.position = target.position;
    }

}
