using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgIslandsSpawn : MonoBehaviour
{
    public GameObject Island1;
    public GameObject Island2;
    public float heightOffset;
    public float spawnRate;
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawn();
            timer = 0;
        }

    }

    void spawn()
    {
        float lowestPoint = transform.position.y - heightOffset;
        int random = Random.Range(1, 3);
        if (random == 1)
        {
            Instantiate(Island1, new Vector3(transform.position.x, Random.Range(transform.position.y - 1, lowestPoint), -1), transform.rotation);
        }
        else
        {
            Instantiate(Island2, new Vector3(transform.position.x, Random.Range(transform.position.y - 1, lowestPoint), -1), transform.rotation);
        }
        
    }
}

