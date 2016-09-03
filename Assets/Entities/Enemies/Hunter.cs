using UnityEngine;
using System.Collections;

public class Hunter : Unit
{
    private Entity target;
    public Weapon weapon;

    private void Awake()
    {
        target = FindObjectOfType<Player>();
    }

    private void FixedUpdate()
    {
        Move(target.transform.position - transform.position);
        Attack(weapon, target.transform.position);
    }
}