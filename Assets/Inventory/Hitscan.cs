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

    // If ready, makes a melee attack. Returns whether an attack was performed.
    override public bool Attack(Vector2 position, Vector2 target)
    {
        if (Ready())
        {
            ResetCooldown();
            return true;
        }
        else
        {
            return false;
        }
    }
}
