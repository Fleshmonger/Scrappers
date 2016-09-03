using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Hitscan), true)]
public class HitscanEditor : WeaponEditor
{
    protected override void UpdateContent()
    {
        base.UpdateContent();
        Hitscan hitscan = target as Hitscan;
        hitscan.Range = EditorGUILayout.FloatField("Range", hitscan.Range);
    }
}
