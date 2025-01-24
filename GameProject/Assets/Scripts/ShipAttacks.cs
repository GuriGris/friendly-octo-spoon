using System.Collections.Generic;
using UnityEngine;

public class ShipAttacks : MonoBehaviour
{
    [SerializeField] private Vector2 mousePosition;

    private void Update() {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        if (Input.GetKeyDown(KeyCode.T)) {
            transform.position = mousePosition;
        }
        if (Input.GetButtonDown("Fire1")) {
            shootProjectile(transform.position, mousePosition);
        }
    }

    void shootProjectile(Vector2 StartPosition, Vector2 TargetPosition) {
        // if (Physics2D.Raycast(StartPosition, TargetPosition)) {

        // }


    }
}
