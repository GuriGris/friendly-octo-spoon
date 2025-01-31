using UnityEngine;

public class BgIslandsSpawn : MonoBehaviour {
    public GameObject Island1;
    public GameObject Island2;
    public float heightOffset;
    public float spawnRate;
    private float timer = 0f;

    void Update()
    {
        if (gameController.gameEnded) return;
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        } else {
            spawn();
            timer = 0;
        }
    }

    void spawn() {
        float lowestPoint = transform.position.y - heightOffset;
        
        int random = Random.Range(1, 3);
        float randomSize = Random.Range(1f, 1.55f);

        if (random == 1)
        {
            GameObject islandInstance = Instantiate(Island1, new Vector3(transform.position.x, Random.Range(transform.position.y - 3, lowestPoint), -1), transform.rotation);

            islandInstance.transform.localScale = new Vector3(randomSize, randomSize, randomSize);

            Renderer objectRenderer = islandInstance.GetComponent<Renderer>();
            Color color = objectRenderer.material.color;
            color.a = 0.85f + (randomSize - 1) / 5;
            Debug.Log(color.a);
            objectRenderer.material.color = color;
        }
        else
        {
            GameObject islandInstance = Instantiate(Island2, new Vector3(transform.position.x, Random.Range(transform.position.y - 3, lowestPoint), -1), transform.rotation);

            islandInstance.transform.localScale = new Vector3(randomSize, randomSize, randomSize);

            Renderer objectRenderer = islandInstance.GetComponent<Renderer>();
            Color color = objectRenderer.material.color;
            color.a = 0.85f + (randomSize - 1)/5;
            Debug.Log(0.85f + (randomSize - 1) / 5);
            objectRenderer.material.color = color;
        }
    }
}

