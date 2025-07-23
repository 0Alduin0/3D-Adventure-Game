using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    public Character cc;

    private void Awake()
    {
        currentHealth = maxHealth;
        cc = GetComponent<Character>();
    }

    public void ApplyDamage(int damage)
    {
        currentHealth -= damage;
    }
}
