using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Spawner), true)]
public class SpawnerEditor : BaseEditor
{
    SerializedProperty wavesProp, spawnPointsProp;

    public void OnEnable()
    {
        wavesProp = serializedObject.FindProperty("waves");
        spawnPointsProp = serializedObject.FindProperty("spawnPoints");
    }

    protected override void UpdateContent()
    {
        EditorGUILayout.PropertyField(wavesProp, true);
        EditorGUILayout.PropertyField(spawnPointsProp, true);
    }
}