using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

class asteroidManager : MonoBehaviour {
    [SerializeField] private GameObject  asteroidPrefab;
    private int asteroidCount;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.S)) {
            if (asteroidCount < 10) {

            }
        }

        Debug.Log(randomInts(1, 5, 5));
    }

    List<int> randomInts(int startNumber, int endNumber, int amount) {
        List<int> numbers = new List<int>();

        for (int i = 0; i < amount; i++) {
            numbers.Add(Random.Range(startNumber, endNumber));
        }

        return numbers;
    }

    void spawnAsteroid(float y) {
        Instantiate(asteroidPrefab, new Vector3(10, y, 0), Quaternion.identity);
    }
}
