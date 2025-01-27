using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Image HealthBar;
    public static float HealthAmount = 100f;
    public float damageAmount;
    public int damageTimer;
    public float MaxDamageTimer;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(5);
        } else if (Input.GetKeyDown(KeyCode.Return))
        {
            TakeDamage(-5);
        }

        UpdateHeatlhBarUI();
    }

    public void UpdateHeatlhBarUI() {
        if (damageTimer < MaxDamageTimer + 1 && MaxDamageTimer != 0) {
            HealthAmount -= damageAmount / MaxDamageTimer;
            HealthBar.fillAmount = HealthAmount / 100f;
            damageTimer += 1;
        }
        if (damageTimer == MaxDamageTimer) {
            damageAmount = 0;
        }
        if (HealthAmount <= 0f) {
            gameController.gameEnded = true;
        }
        if (HealthAmount > 100f) {
            HealthAmount = 100;
            HealthBar.fillAmount = 1;
        }

        if (HealthAmount < 75f && HealthAmount > 50f) {
            HealthBar.color = new Color(243f / 255f, 198f / 255f, 35f / 255f);
        }
        if (HealthAmount < 50f && HealthAmount > 25f) {
            HealthBar.color = new Color(235f / 255f, 131f / 255f, 23f / 255f);
        }
        if (HealthAmount < 25f) {
            HealthBar.color = new Color(255f / 255f, 0f / 255f, 0f / 255f);
        }
        if (HealthAmount > 75f) {
            HealthBar.color = new Color(92f / 255f, 255f / 255f, 0f / 255f);
        }
    }

    public void TakeDamage(float damage)
    {
        if (damageAmount == 0)
        {
            damageTimer = 0;
        }
        damageAmount += damage;
        MaxDamageTimer = Mathf.Abs(damageAmount * 10f);
    }
}
