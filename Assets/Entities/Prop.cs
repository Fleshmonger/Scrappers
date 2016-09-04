using UnityEngine;

// Destructible gameObject
public class Prop : MonoBehaviour
{
    public bool invulnerable = false;

    [SerializeField]
    private int _health;

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

    // Damages the prop by the given damage amount.
    // Destroys the gameobject if the prop dies.
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

    // Returns whether the prop has lost all health.
    public bool IsDead()
    {
        return !invulnerable && Health <= 0;
    }
}
