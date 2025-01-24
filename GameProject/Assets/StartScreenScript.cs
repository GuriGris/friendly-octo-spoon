using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScreenScript : MonoBehaviour
{
    public GameObject ship;
    public bool playClicked = false;
    public float startPoint;
    private Animator animator;
    public bool start = false;
    // public RawImage selectedShipImg;

    public void startGame()
    {
        animator = ship.GetComponent<Animator>();
        playClicked = true;
        animator.SetBool("playClicked", true);
        startPoint = ship.transform.position.x;
    }

    public void flyAway()
    {
        animator.enabled = false;
        start = true;
    }

    private void Update()
    {
        if (start)
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
