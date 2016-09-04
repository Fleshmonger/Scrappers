using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Projectile), true)]
public class ProjectileEditor : BaseEditor
{
    protected override void UpdateContent()
    {
        Projectile projectile = target as Projectile;
        projectile.Speed = EditorGUILayout.FloatField("Speed", projectile.Speed);
        projectile.Lifespan = EditorGUILayout.FloatField("Lifespan", projectile.Lifespan);
    }
}