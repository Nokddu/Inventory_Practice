using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public Button exitbtn;
    public List<UISlot> slot = new List<UISlot>();
    public GameObject uislot;
    public Transform content;
    public void SetActive()
    {
        gameObject.SetActive(false);
    }
    private void Start()
    {
        exitbtn.onClick.AddListener(SetActive);
        
    }

    public void InitInventoryUI()
    {
        //for (int i = 0; i < slot.Count; i++)
        //{
        //    slot[i] = Instantiate(uislot, content);
        //}
        RefreshInventory();
    }

    public void RefreshInventory()
    {
        foreach (UISlot slot in slot)
        {
            Destroy(slot.gameObject);
        }
        slot.Clear();

        List<Item> playerInventory = GameManager.Instance.Player.Inventory;

        for (int i = 0; i < playerInventory.Count; i++)
        {
            GameObject slotObject = Instantiate(uislot, content);
            UISlot newSlot = slotObject.GetComponent<UISlot>();

            newSlot.SetItem(playerInventory[i]);

            slot.Add(newSlot);
        }
    }

}
