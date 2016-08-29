using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Unit), true)]
public class UnitEditor : Editor
{
    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        Unit unit = target as Unit;

        unit.invulnerable = EditorGUILayout.Toggle("Invulnerable", unit.invulnerable);
        unit.Health = EditorGUILayout.IntField("Health", unit.Health);
        unit.Speed = EditorGUILayout.IntField("Speed", unit.Speed);
        serializedObject.ApplyModifiedProperties();
    }
}