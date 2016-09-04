using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Vector2 direction = Vector2.zero;
    private int _damage;
    [SerializeField] private float _speed, _lifespan;

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
        Vector3 translation = direction.normalized * Speed * Time.deltaTime;
        transform.position += translation;
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