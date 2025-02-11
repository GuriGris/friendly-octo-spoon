using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject ship;

    void Update()
    {
        Vector2 pos = ship.transform.position;
        transform.position = new Vector3(pos.x, pos.y, transform.position.z);
    }
}
