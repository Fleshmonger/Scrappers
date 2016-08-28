using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Hitscan), true)]
public class HitscanEditor : WeaponEditor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Hitscan hitscan = target as Hitscan;

        hitscan.Range = EditorGUILayout.FloatField("Range", hitscan.Range);
    }
}
