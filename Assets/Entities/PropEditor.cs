using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Prop), true)]
public class PropEditor : BaseEditor
{
    // Updates all the content in the inspector.
    protected override void UpdateContent()
    {
        Prop prop = target as Prop;
        prop.invulnerable = EditorGUILayout.Toggle("Invulnerable", prop.invulnerable);
        prop.Health = EditorGUILayout.IntField("Health", prop.Health);
    }
}