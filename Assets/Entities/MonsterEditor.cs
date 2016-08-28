using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Monster), true)]
public class MonsterEditor : UnitEditor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Monster monster = target as Monster;

        monster.player = EditorGUILayout.ObjectField("Player", monster.player, typeof(Player), true) as Player;
    }
}