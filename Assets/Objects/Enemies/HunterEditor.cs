using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Hunter), true)]
public class HunterEditor : UnitEditor
{
    protected override void UpdateContent()
    {
        base.UpdateContent();
        Hunter hunter = target as Hunter;
        hunter.weapon = EditorGUILayout.ObjectField("Weapon", hunter.weapon, typeof(Weapon), true) as Weapon;
    }
}