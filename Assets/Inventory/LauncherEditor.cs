using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Launcher), true)]
public class LauncherEditor : WeaponEditor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Launcher launcher = target as Launcher;

        launcher.projectilePrefab = EditorGUILayout.ObjectField("Projectile Prefab", launcher.projectilePrefab, typeof(Projectile), true) as Projectile;
    }
}
