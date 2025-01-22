using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenScript : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("GameScreen");
    }
}
