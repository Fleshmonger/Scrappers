using UnityEngine;

[CreateAssetMenu(fileName = "NewFactionScript", menuName = "Scripts/Faction", order = 1)]
public class Faction : ScriptableObject
{
    public int unitLayer, attackLayer;
}