using UnityEngine;

public class asteroidCollider : MonoBehaviour
{
    [SerializeField] private float damageOnCollide = 5f;
    public void OnTriggerEnter2D(Collider2D collision) {
        if (gameController.gameEnded) return;
        collision.GetComponent<HealthManager>().TakeDamage(damageOnCollide);
    }
}
