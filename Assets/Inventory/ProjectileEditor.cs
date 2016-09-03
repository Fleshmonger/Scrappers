using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Projectile), true)]
public class ProjectileEditor : EntityEditor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Projectile projectile = target as Projectile;

        projectile.Lifespan = EditorGUILayout.FloatField("Lifespan", projectile.Lifespan);
    }
}