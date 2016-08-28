using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Player), true)]
public class PlayerEditor : UnitEditor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Player player = target as Player;

        player.weapon = EditorGUILayout.ObjectField("Weapon", player.weapon, typeof(Weapon), true) as Weapon;
    }
}