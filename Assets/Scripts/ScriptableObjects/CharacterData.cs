using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "Selector/CharacterData")]
public class CharacterData : ScriptableObject
{
    public string characterName;
    public GameObject characterPrefab;
}
