using UnityEngine;

public class Unit : Entity
{
    public bool invulnerable = false;
    public Faction faction;
    [SerializeField] private int _health;

    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = Mathf.Max(value, 0);
        }
    }

    public void Attack(Weapon weapon, Vector2 target)
    {
        if (weapon)
        {
            int attackLayer = 0;
            if (faction)
            {
                attackLayer = faction.attackLayer;
            }
            weapon.Attack(transform.position, target, attackLayer);
        }
    }

    public void Hurt(int damage)
    {
        if (!invulnerable || damage > 0)
        {
            Health -= damage;
            if (IsDead())
            {
                Destroy(gameObject);
            }
        }
    }

    public bool IsDead()
    {
        return !invulnerable && Health <= 0;
    }
}