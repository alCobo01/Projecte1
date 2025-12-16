using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterSelector : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private List<CharacterData> characters;
    [SerializeField] private TextMeshProUGUI characterNameText;

    private int currentIndex = 0;
    private GameObject currentCharacter;

    private void Start()
    {
        UpdateCharacter(currentIndex);
    }

    public void NextCharacter()
    {
        currentIndex++;
        if (currentIndex >= characters.Count) currentIndex = 0;
        UpdateCharacter(currentIndex);
    }

    public void PreviousCharacter()
    {
        currentIndex--;
        if (currentIndex < 0) currentIndex = characters.Count - 1;
        UpdateCharacter(currentIndex);
    }

    private void UpdateCharacter(int index)
    {
        if (currentCharacter != null)
            Destroy(currentCharacter);

        CharacterData characterData = characters[index];
        currentCharacter = Instantiate(characterData.characterPrefab, spawnPoint.position, spawnPoint.rotation);
        characterNameText.text = characterData.characterName;
    }

}
