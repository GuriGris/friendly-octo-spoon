using UnityEngine;

public class BgIslandsSpawn : MonoBehaviour {
    public GameObject Island1;
    public GameObject Island2;
    public float heightOffset;
    public float spawnRate;
    private float timer = 0f;

    void Update() {
        if (gameController.gameEnded) return;

        if (timer < spawnRate) {
            timer += Time.deltaTime;
        } else {
            spawn();
            timer = 0;
        }
    }

    void spawn() {
        float lowestPoint = transform.position.y - heightOffset;
        
        GameObject[] islands = { Island1, Island2 };
        int random = Random.Range(0, 2);
        Instantiate(islands[random], new Vector3(transform.position.x, Random.Range(transform.position.y - 1, lowestPoint), -1), transform.rotation);


    }
}

