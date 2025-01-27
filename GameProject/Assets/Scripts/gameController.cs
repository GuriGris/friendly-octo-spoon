using UnityEngine;
using UnityEngine.UI;

public class gameController : MonoBehaviour {
    public static bool gameEnded = false;
    public bool publicGameEnd;
    public GameObject gameOverUI;
    public Button restartGameBtn;
    public Transform playerShip;

    private void Awake() {
        restartGameBtn.onClick.AddListener(RestartGame);
    }

    private void Start() {
        gameOverUI.SetActive(false);
    }

    private void Update() {
        Debug.Log(gameEnded);
        if (gameEnded) {
            gameOverUI.SetActive(true);
        }
        publicGameEnd = gameEnded;
    }

    private void RestartGame() {
        HealthManager.HealthAmount = 100f;
        playerShip.GetComponent<HealthManager>().UpdateHeatlhBarUI();

        gameEnded = false;
        gameOverUI.SetActive(false);

        // Removing all asteroids in the scene
        asteroidController[] asteroids = FindObjectsByType<asteroidController>(FindObjectsSortMode.None);
        foreach (asteroidController asteroid in asteroids) {
            Destroy(asteroid.gameObject);
        }

        // Removing all islands in the scene
        MoveIsland[] islands = FindObjectsByType<MoveIsland>(FindObjectsSortMode.None);
        foreach (MoveIsland island in islands) {
            Destroy(island.gameObject);
        }
    }
}