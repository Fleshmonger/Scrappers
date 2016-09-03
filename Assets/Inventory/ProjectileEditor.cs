using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Projectile), true)]
public class ProjectileEditor : EntityEditor
{
    protected override void UpdateContent()
    {
        base.UpdateContent();
        Projectile projectile = target as Projectile;
        projectile.Lifespan = EditorGUILayout.FloatField("Lifespan", projectile.Lifespan);
    }
}