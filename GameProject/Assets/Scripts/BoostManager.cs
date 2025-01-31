using UnityEngine;
using UnityEngine.UI;

public class BoostManager : MonoBehaviour
{
    public Slider slider;
    public Image fill;
    public float BoostAmount = 20f;
    public float fractions = 1f;
    public float boost;
    public float TargetBoost = 20f;
    public float diff;
    public float count;
    public Gradient gradient;

    private void Start()
    {
        fill.color = gradient.Evaluate(1f);
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            UpdateBoost(0.1f);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            UpdateBoost(-5);
        }

        UpdatesliderUI();
    }

    public void UpdatesliderUI()
    {
        if (fractions > 1)
        {
            BoostAmount -= diff / fractions;
            slider.value = BoostAmount;
            count += 1;
        }

        if (BoostAmount > 20f)
        {
            BoostAmount = 20f;
            slider.value = 20;
            TargetBoost = 20f;
        }

        if (count >= fractions)
        {
            BoostAmount = TargetBoost;
            fractions = 1;
            count = 0;
        }

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    public void UpdateBoost(float boost)
    {
        TargetBoost -= boost;
        fractions = Mathf.Abs(BoostAmount - TargetBoost) * 5f;
        count = 0;
        diff = BoostAmount - TargetBoost;
    }

    public void SetMaxHealth()
    {
        BoostAmount = 20;
        slider.value = 20;
        TargetBoost = 20f;
        fractions = 1;
        count = 0;
    }
}