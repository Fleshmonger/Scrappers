using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Unit), true)]
public class UnitEditor : EntityEditor
{
    // Updates all the content in the inspector.
    protected override void UpdateContent()
    {
        base.UpdateContent();
        Unit unit = target as Unit;

        unit.faction = EditorGUILayout.ObjectField("Faction", unit.faction, typeof(Faction), true) as Faction;
        unit.invulnerable = EditorGUILayout.Toggle("Invulnerable", unit.invulnerable);
        unit.Health = EditorGUILayout.IntField("Health", unit.Health);
    }
}