using UnityEngine;
using System.Collections;

public class Projectile : Unit
{
    public Vector2 direction = Vector2.zero;
    private int _damage;
    [SerializeField] private float _lifespan;

    public int Damage
    {
        get
        {
            return _damage;
        }
        set
        {
            _damage = Mathf.Max(value, 0);
        }
    }
    public float Lifespan
    {
        get
        {
            return _lifespan;
        }
        set
        {
            _lifespan = Mathf.Max(value, 0f);
        }
    }

    private void Awake()
    {
        Destroy(gameObject, Lifespan);
    }

    private void Update()
    {
        Move(direction);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Unit unit = other.GetComponent<Unit>();
        if (unit)
        {
            unit.Hurt(Damage);
        }
        Destroy(gameObject);
    }
}