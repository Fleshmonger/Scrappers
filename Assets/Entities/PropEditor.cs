using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Prop), true)]
public class PropEditor : BaseEditor
{
    // Updates all the content in the inspector.
    protected override void UpdateContent()
    {
        Prop entity = target as Prop;
        entity.Speed = EditorGUILayout.FloatField("Speed", entity.Speed);
    }
}