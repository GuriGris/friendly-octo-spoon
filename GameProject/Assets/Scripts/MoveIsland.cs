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
        speed = Random.Range(1f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < deathPoint)
        {
            Destroy(gameObject);
        }
    }
}

