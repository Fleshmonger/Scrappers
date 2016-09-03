using UnityEngine;
using UnityEditor;

public abstract class BaseEditor : Editor
{
    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        UpdateContent();
        serializedObject.ApplyModifiedProperties();
    }

    // Updates all the content in the inspector.
    protected abstract void UpdateContent();
}