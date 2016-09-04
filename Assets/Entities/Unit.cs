using UnityEngine;

// Mobile and attacking gameObject.
public class Unit : Prop
{
    public Faction faction;

    [SerializeField]
    private float _speed;

    public float Speed
    {
        get
        {
            return _speed;
        }
        set
        {
            _speed = Mathf.Max(value, 0f);
        }
    }

    // TODO Move this to weapons.
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

    // Moves the unit. If a rigidbody2d is attached, sets a velocity instead.
    public void Move(Vector2 direction)
    {
        Rigidbody2D body = GetComponent<Rigidbody2D>();
        if (body)
        {
            body.velocity = direction.normalized * Speed;
        }
        else
        {
            Vector3 translation = direction.normalized * Speed * Time.deltaTime;
            transform.position += translation;
        }
    }
}