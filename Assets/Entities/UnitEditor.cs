using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Unit), true)]
public class UnitEditor : EntityEditor
{
    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        base.OnInspectorGUI();
        Unit unit = target as Unit;

        unit.faction = EditorGUILayout.ObjectField("Faction", unit.faction, typeof(Faction), true) as Faction;
        unit.invulnerable = EditorGUILayout.Toggle("Invulnerable", unit.invulnerable);
        unit.Health = EditorGUILayout.IntField("Health", unit.Health);
        serializedObject.ApplyModifiedProperties();
    }
}