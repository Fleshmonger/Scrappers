using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Projectile), true)]
public class ProjectileEditor : UnitEditor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Projectile projectile = target as Projectile;

        projectile.Damage = EditorGUILayout.IntField("Damage", projectile.Damage);
        projectile.Lifespan = EditorGUILayout.FloatField("Lifespan", projectile.Lifespan);
    }
}