using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Slider HealthBar;
    public Image fill;
    public float HealthAmount = 20f;
    public float fractions = 1f;
    public float damage;
    public float TargetHealth = 20f;
    public float diff;
    public float count;
    public Gradient gradient;

    private void Start()
    {
        fill.color = gradient.Evaluate(1f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            TakeDamage(-5);
        }

        UpdateHealthBarUI();
    }

    public void UpdateHealthBarUI() {
        if (fractions > 1)
        {
            HealthAmount -= diff / fractions;
            HealthBar.value = HealthAmount;
            count += 1;
        }

        if (HealthAmount > 20f) {
            HealthAmount = 20f;
            HealthBar.value = 20;
            TargetHealth = 20f;
        }

        if (count >= fractions)
        {
            HealthAmount = TargetHealth;
            fractions = 1;
            count = 0;
        }

        if (HealthAmount <= 0f)
        {
            gameController.gameEnded = true;
        }
        fill.color = gradient.Evaluate(HealthBar.normalizedValue);
    }

    public void TakeDamage(float damage)
    {
        TargetHealth -= damage;
        fractions = Mathf.Abs(HealthAmount - TargetHealth) * 5f;
        count = 0;
        diff = HealthAmount - TargetHealth;
    }

    public void SetMaxHealth()
    {
        HealthAmount = 20;
        HealthBar.value = 20;
        TargetHealth = 20f;
        fractions = 1;
        count = 0;
    }
}
