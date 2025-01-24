using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public GameObject Logic;
    private StartScreenScript script;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void AnimationEnd()
    {
        script = Logic.GetComponent<StartScreenScript>();
        script.flyAway();
    }
}
