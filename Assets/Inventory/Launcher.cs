using UnityEngine;

[CreateAssetMenu(fileName = "NewLauncherItem", menuName = "Inventory/Launcher", order = 1)]
public class Launcher : Weapon
{
    public Projectile projectilePrefab;

    // If ready, makes a melee attack. Returns whether an attack was performed.
    override public bool Attack(Vector2 origin, Vector2 target)
    {
        if (Ready())
        {
            Projectile projectile = Instantiate<Projectile>(projectilePrefab);
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
