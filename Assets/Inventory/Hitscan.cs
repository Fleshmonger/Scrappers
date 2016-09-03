using UnityEngine;

[CreateAssetMenu(fileName = "NewHitscanItem", menuName = "Inventory/Hitscan", order = 1)]
public class Hitscan : Weapon
{
    [SerializeField] private float _range;
    public float Range
    {
        get
        {
            return _range;
        }
        set
        {
            _range = Mathf.Max(value, 0f);
        }
    }

    // Returns whether the target is within range
    public override bool Targetable(Vector2 origin, Vector2 target)
    {
        return Vector2.Distance(origin, target) <= Range;
    }

    // If ready, makes a melee attack. Returns whether an attack was performed.
    override public bool Attack(Vector2 origin, Vector2 target, int layer)
    {
        if (Ready())
        {
            int layerMask = ~((1<<layer)|(1<<LayerMask.NameToLayer("Ignore Raycast"))); // Everything except "layer" and "IgnoreRayCast"
            RaycastHit2D rayHit = Physics2D.Raycast(origin, target - origin, Range, layerMask);
            if (rayHit.collider)
            {
                Unit other = rayHit.collider.gameObject.GetComponent<Unit>();
                if (other)
                {
                    other.Hurt(Damage);
                }
            }
            ResetCooldown();
            return true;
        }
        else
        {
            return false;
        }
    }
}
