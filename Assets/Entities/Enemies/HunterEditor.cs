using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Hunter), true)]
public class HunterEditor : UnitEditor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Hunter hunter = target as Hunter;

        hunter.player = EditorGUILayout.ObjectField("Player", hunter.player, typeof(Player), true) as Player;
        hunter.weapon = EditorGUILayout.ObjectField("Weapon", hunter.weapon, typeof(Weapon), true) as Weapon;
    }
}