using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIsland : MonoBehaviour
{
    public float speed;
    private float deathPoint = -10.5f;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.8f;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameController.gameEnded) return;
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < deathPoint)
        {
            Destroy(gameObject);
        }
    }
}

