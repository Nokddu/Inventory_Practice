using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    
    [SerializeField] UIMainMenu uiMain;
    [SerializeField] UIInventory uiInven;
    [SerializeField] UIStatus uiStatus;

    public UIMainMenu UIMain { get { return uiMain; } }
    public UIInventory UIInventory { get { return uiInven; } }
    public UIStatus UIStatus { get { return uiStatus; } }

    private void Awake()
    {
        if (Instance == null)
        {
           Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


}
