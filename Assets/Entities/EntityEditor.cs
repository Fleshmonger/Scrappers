using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Entity), true)]
public class EntityEditor : BaseEditor
{
    // Updates all the content in the inspector.
    protected override void UpdateContent()
    {
        Entity entity = target as Entity;
        entity.Speed = EditorGUILayout.FloatField("Speed", entity.Speed);
    }
}