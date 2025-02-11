using System.Collections.Generic;
using UnityEngine;

public class ShipAttacks : MonoBehaviour
{
    [SerializeField] private Vector2 mousePosition;
    public GameObject projectile;

    private void Update() {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject asteroid = Instantiate(projectile, new Vector3(transform.position.x, transform.position.y, transform.position.z) + transform.up * 1, transform.rotation);
        }
    }
}
