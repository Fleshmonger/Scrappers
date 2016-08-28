using UnityEngine;

public abstract class Weapon : ScriptableObject
{
    private float lastAttackTime;

    [SerializeField] private int _damage;
    [SerializeField] private float _cooldown;
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
    public float Cooldown
    {
        get
        {
            return _cooldown;
        }
        set
        {
            _cooldown = Mathf.Max(value, 0);
        }
    }

    private void OnEnable()
    {
        lastAttackTime = Time.timeSinceLevelLoad - Cooldown;
    }

    // Returns whether the weapon is off cooldown.
    public bool Ready()
    {
        return Time.timeSinceLevelLoad >= lastAttackTime + Cooldown;
    }

    // Updates the last time an attack was performed.
    protected void ResetCooldown()
    {
        lastAttackTime = Time.timeSinceLevelLoad;
    }

    abstract public bool Attack(Vector2 origin, Vector2 target);
}