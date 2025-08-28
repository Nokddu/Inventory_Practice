using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    public TextMeshProUGUI attack;
    public TextMeshProUGUI defense;
    public TextMeshProUGUI health;
    public TextMeshProUGUI crit;

    public Button Exitbtn;

    private void Start()
    {
        Exitbtn.onClick.AddListener(SetActive);

        SetCharacterInfo(GameManager.Instance.Player);
    }

    public void SetActive()
    {
        gameObject.SetActive(false);
    }

    public void SetCharacterInfo(Character character)
    {
        attack.text = character.attack.ToString();
        defense.text = character.defense.ToString();
        health.text = character.health.ToString();
        crit.text = character.crit.ToString();
    }
}
