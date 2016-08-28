using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour
{
    public bool invulnerable = false;
    [SerializeField] private int _speed, _health;

    public int Speed
    {
        get
        {
            return _speed;
        }
        set
        {
            _speed = Mathf.Max(0, value);
        }
    }
    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = Mathf.Max(0, value);
        }
    }

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