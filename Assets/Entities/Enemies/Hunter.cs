using UnityEngine;
using System.Collections;

public class Hunter : Unit
{
    public Player player;
    public Weapon weapon;

    private void Awake()
    {
        player = FindObjectOfType<Player>();
    }

    private void FixedUpdate()
    {
        Move(player.transform.position - transform.position);
        Attack(weapon, player.transform.position);
    }
}