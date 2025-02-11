using UnityEngine;

class asteroidController : MonoBehaviour {
    [SerializeField] private float moveSpeed = 15f;
    Quaternion rotation;

    ShipAttacks ship;
    Rigidbody2D myRigidbody;

    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        ship = FindFirstObjectByType<ShipAttacks>();

        rotation = ship.transform.rotation;
    }

    void Update() {
        myRigidbody.linearVelocity = rotation * Vector2.up * moveSpeed;
    }
}