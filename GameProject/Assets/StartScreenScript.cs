using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScreenScript : MonoBehaviour
{
    public GameObject ship;
    public bool playClicked = false;
    public float startPoint;
    // public RawImage selectedShipImg;

    public void startGame()
    {
        playClicked = true;
        startPoint = ship.transform.position.x;
    }

    private void Update()
    {
        if (playClicked)
        {
            ship.transform.position += Vector3.right * Time.deltaTime * 100 * 3;
        }
        if (ship.transform.position.x - startPoint > Screen.width*0.75f)
        {
            Destroy(ship);
            SceneManager.LoadScene("GameScreen");
        }
    }
}
