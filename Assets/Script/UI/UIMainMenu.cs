using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMainMenu : MonoBehaviour
{
    public void OpenMainMenu()
    {
        UIManager.Instance.UIMain.gameObject.SetActive(true);
    }

    public void OpenStatus()
    {
        UIManager.Instance.UIStatus.gameObject.SetActive(true);
    }

    public void OpenInventory()
    {
        UIManager.Instance.UIInventory.gameObject.SetActive(true);
    }
}
