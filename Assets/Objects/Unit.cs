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