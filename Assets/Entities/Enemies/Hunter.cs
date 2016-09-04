using UnityEngine;
using System.Collections;

public class Hunter : Unit
{
    private Prop target;
    public Weapon weapon;

    private void Awake()
    {
        target = FindObjectOfType<Player>();
    }

    private void FixedUpdate()
    {
        Move(target.transform.position - transform.position);
        weapon.Attack(transform.position, target.transform.position, faction);
    }
}