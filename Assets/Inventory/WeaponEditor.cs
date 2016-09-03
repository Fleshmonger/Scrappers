using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Weapon), true)]
public class WeaponEditor : BaseEditor
{
    protected override void UpdateContent()
    {
        // Save any changes to the object.
        EditorUtility.SetDirty(target);

        Weapon weapon = target as Weapon;

        weapon.Damage = EditorGUILayout.IntField("Damage", weapon.Damage);
        weapon.Cooldown = EditorGUILayout.FloatField("Cooldown", weapon.Cooldown);
    }
}