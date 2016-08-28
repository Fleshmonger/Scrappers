using UnityEngine;
using System.Collections;

public class Monster : Unit
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
    }
}