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

    // Returns whether the weapon can hit the given target.
    abstract public bool Targetable(Vector2 origin, Vector2 target);

    // Performs an attack towards the target, with the given layer as source.
    // Layers are expected to either be Player or Enemy; the attack will ignore the given layer.
    abstract public bool Attack(Vector2 origin, Vector2 target, int layer);

    public bool Attack(Vector2 origin, Vector2 target, Faction faction)
    {
        int attackLayer = 0;
        if (faction)
        {
            attackLayer = faction.attackLayer;
        }
        return Attack(origin, target, attackLayer);
    }
}