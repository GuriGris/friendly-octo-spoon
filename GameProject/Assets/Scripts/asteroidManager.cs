using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class asteroidManager : MonoBehaviour {
    [SerializeField] private GameObject  asteroidPrefab;
    
    [Range(1f, 5f)]
    [SerializeField] private float minPauseTime = 2f;

    [Range(1f, 5f)]
    [SerializeField] private float maxPauseTime = 3f;

    private List<int> allowedYValues = new List<int> { 4, 2, 0, -2, -4 };

    private void Start() {
        StartCoroutine(asteroidSpawner());
        
    }

    // Spawns an asteroid belt every two seconds if game not is ended
    private IEnumerator asteroidSpawner () {
        while (!gameController.gameEnded) {
            float interval = Random.Range(minPauseTime, maxPauseTime+0.1f);
            spawnAsteroidBelt(1, 4);
            yield return new WaitForSeconds(interval);
        }
    }

    void spawnAsteroidBelt(int minAsteroids, int maxAsteroids) {
        int amountOfAsteroids = Random.Range(minAsteroids, maxAsteroids+1);
        List<int> yValuesSack = new List<int>(allowedYValues);

        for (int i = 0; i<amountOfAsteroids; i++) {
            if (yValuesSack.Count > 0) {
                int randomIndex = Random.Range(0, yValuesSack.Count);
                int randomY = yValuesSack[randomIndex];  // Get a random item from list
                yValuesSack.RemoveAt(randomIndex);  // Remove the random item from list
                spawnAsteroid(randomY);
            }
        }
    }

    void spawnAsteroid(float y) {
        Instantiate(asteroidPrefab, new Vector3(10, y, -3), Quaternion.identity);
    }
}
