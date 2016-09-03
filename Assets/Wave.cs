using UnityEngine;

[CreateAssetMenu(fileName = "NewWaveScript", menuName = "Scripts/Wave", order = 1)]
public class Wave : ScriptableObject
{
    public Unit[] unitPrefabs;
}