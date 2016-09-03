using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Launcher), true)]
public class LauncherEditor : WeaponEditor
{
    protected override void UpdateContent()
    {
        base.UpdateContent();
        Launcher launcher = target as Launcher;
        launcher.projectilePrefab = EditorGUILayout.ObjectField("Projectile Prefab", launcher.projectilePrefab, typeof(Projectile), true) as Projectile;
    }
}
