using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject ship;

    void Update()
    {
        Vector3 pos = ship.transform.position;
        transform.position = pos;
    }
}
