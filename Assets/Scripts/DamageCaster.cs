using System.Collections.Generic;
using UnityEngine;

public class DamageCaster : MonoBehaviour
{
    public Collider damageCasterColider;

    public int damage = 30;

    public string targetTag;

    public List<Collider> damagedTargetList;

    private void Awake()
    {
        damageCasterColider = GetComponent<Collider>();
        damageCasterColider.enabled = false;
        damagedTargetList = new List<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == targetTag && !damagedTargetList.Contains(other))
        {
            Character targetCC = other.GetComponent<Character>();

            if (targetCC != null)
            {
                targetCC.ApplyDamage(damage);
            }
            damagedTargetList.Add(other);
        }
    }

    public void EnableDamageCaster()
    {
        damagedTargetList.Clear();
        damageCasterColider.enabled = true;
    }
    public void DisableDamageCaster()
    {
        damagedTargetList.Clear();
        damageCasterColider.enabled = false;
    }
}
