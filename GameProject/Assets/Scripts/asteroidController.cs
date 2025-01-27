﻿using UnityEngine;

class asteroidController : MonoBehaviour {
    [SerializeField] private float moveSpeed = 1f;
    private void Update() {
        if (gameController.gameEnded) return;
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        if (transform.position.x < -10) {
            //transform.position = new Vector3(10, transform.position.y, -3);
            Destroy(gameObject);
        }
    }
}