using System.Collections.Generic;
using UnityEngine;

class asteroidManager : MonoBehaviour {
    [SerializeField] private GameObject  asteroidPrefab;
    private List<int> allowedYValues = new List<int> { 4, 2, 0, -2, -4 };

    private void Update() {
        if (Input.GetKeyDown(KeyCode.S)) {

            spawnAsteroidBelt(1, 4);
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
