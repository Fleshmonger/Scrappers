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

    // Makes a racasted-attack.
    override protected void Fire(Vector2 origin, Vector2 target, Faction faction)
    {
        // Mask "Ignore Raycast" layer
        int layerMask = 1<<LayerMask.NameToLayer("Ignore Raycast");
        if (faction)
        {
            // Also mask friendly units and attacks.
            layerMask = layerMask | (1 << faction.unitLayer) | (1 << faction.attackLayer);
        }
        // Flip mask to ignore the specified layers.
        layerMask = ~layerMask;

        RaycastHit2D rayHit = Physics2D.Raycast(origin, target - origin, Range, layerMask);
        if (rayHit.collider)
        {
            Unit other = rayHit.collider.gameObject.GetComponent<Unit>();
            if (other)
            {
                other.Hurt(Damage);
            }
        }
    }
}
