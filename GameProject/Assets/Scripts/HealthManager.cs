using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Image HealthBar;
    public float HealthAmount;
    public float damageAmount;
    public int damageTimer;
    public float MaxDamageTimer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HealthAmount = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            takeDamage(5);
        } else if (Input.GetKeyDown(KeyCode.Return))
        {
            takeDamage(-5);
        }
        if (damageTimer < MaxDamageTimer + 1)
        {
            HealthAmount -= damageAmount / MaxDamageTimer;
            HealthBar.fillAmount = HealthAmount / 100f;
            damageTimer += 1;
        }
        if (damageTimer == MaxDamageTimer)
        {
            damageAmount = 0;
        }
        if (HealthAmount <= 0)
        {
            Debug.Log("game over");
        }
        if (HealthAmount >= 100f)
        {
            HealthAmount = 100;
            HealthBar.fillAmount = 1;
        }
    }

    public void takeDamage(float damage)
    {
        if (damageAmount == 0)
        {
            damageTimer = 0;
        }
        damageAmount += damage;
        MaxDamageTimer = Mathf.Abs(damageAmount * 10f);
    }
}
