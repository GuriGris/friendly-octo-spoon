using UnityEngine;
using UnityEngine.UI;

public class BoostManager : MonoBehaviour
{ 
    public Slider slider;
    public Image fill;
    public float BoostAmount = 20f;
    public ShipMovement shipMovement;
    public float BoostUsage;
    public float BoostRecovery;

    private void Start()
    {
        shipMovement = GetComponent<ShipMovement>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0) && BoostAmount > 0)
        {
            BoostAmount -= BoostUsage / 100;
            slider.value = BoostAmount;
            shipMovement.boosting = true;
        } else
        {
            shipMovement.boosting = false;
            BoostAmount += BoostRecovery / 100;
            slider.value = BoostAmount;
        }
        if (BoostAmount > 20)
        {
            SetMaxBoost();
        }
    }


    public void SetMaxBoost()
    {
        BoostAmount = 20;
        slider.value = 20;
    }
}