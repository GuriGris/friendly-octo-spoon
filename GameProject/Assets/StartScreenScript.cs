using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScreenScript : MonoBehaviour
{
    public GameObject[] ships;

    public void startGame()
    {
        SceneManager.LoadScene("GameScreen");
    }

    public void setActive(int n)
    {
        for (int i = 0; i < 4; i++)
        {
            ships[i].GetComponent<RawImage>().color = new Color(241f / 255f, 150f / 255f, 71f / 255f);
        }
        ships[n].GetComponent<RawImage>().color = new Color(255f / 255f, 100f / 255f, 51f / 255f);
    }
}
