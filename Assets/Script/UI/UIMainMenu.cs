using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{

    public Button mainBtn;
    public Button invenBtn;
    public Button statusBtn;
    private Canvas canvas;
    public TextMeshProUGUI characterName;
    public TextMeshProUGUI characterLevel;
    public TextMeshProUGUI characterExp;

    private void Start()
    {
        mainBtn.onClick.AddListener(OpenMainMenu);
        invenBtn.onClick.AddListener(OpenInventory);
        statusBtn.onClick.AddListener(OpenStatus);
        canvas = GetComponent<Canvas>();

        canvas.enabled = false;
        SetCharacterInfo(GameManager.Instance.Player);
    }

    public void OpenMainMenu()
    {
        canvas.enabled = true;
    }

    public void OpenStatus()
    {
        UIManager.Instance.UIStatus.gameObject.SetActive(true);
    }

    public void OpenInventory()
    {
        UIManager.Instance.UIInventory.gameObject.SetActive(true);
        UIManager.Instance.UIInventory.InitInventoryUI();
    }

    public void SetCharacterInfo(Character character)
    {
        characterName.text = character.nickname;
        characterLevel.text = character.level.ToString();
        characterExp.text = character.exp.ToString();
    }
}
