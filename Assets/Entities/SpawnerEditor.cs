using UnityEngine;
using UnityEditor;

//[CustomEditor(typeof(Spawner), true)]
public class SpawnerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        Spawner spawner = target as Spawner;
    }
}