using UnityEngine;

[CreateAssetMenu(fileName = "NewLauncherItem", menuName = "Inventory/Launcher", order = 1)]
public class Launcher : Weapon
{
    public Projectile projectilePrefab;

    // Returns whether the projectile will reach the target within lifespan.
    public override bool Targetable(Vector2 origin, Vector2 target)
    {
        return Vector2.Distance(origin, target) <= projectilePrefab.Speed * projectilePrefab.Lifespan;
    }

    // If ready, launches a projectile. Returns whether an attack was performed.
    override public bool Attack(Vector2 origin, Vector2 target, Faction faction)
    {
        if (Ready())
        {
            Projectile projectile = Instantiate<Projectile>(projectilePrefab);
            if (faction)
            {
                // Ignore friendly objects.
                projectile.gameObject.layer = faction.attackLayer;
            }
            projectile.Damage = Damage;
            projectile.transform.position = origin;
            projectile.direction = target - origin;
            ResetCooldown();
            return true;
        }
        else
        {
            return false;
        }
    }
}
