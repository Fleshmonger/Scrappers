using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Weapon), true)]
public class WeaponEditor : Editor
{
    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        Weapon weapon = target as Weapon;

        weapon.Damage = EditorGUILayout.IntField("Damage", weapon.Damage);
        weapon.Cooldown = EditorGUILayout.FloatField("Cooldown", weapon.Cooldown);
    }
}