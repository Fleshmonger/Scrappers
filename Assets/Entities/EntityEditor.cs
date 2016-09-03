using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Entity), true)]
public class EntityEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Entity entity = target as Entity;

        entity.Speed = EditorGUILayout.FloatField("Speed", entity.Speed);
    }
}