using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Sprite sword;
    public Sprite shield;
    public Sprite armor;


    private Character player;
    public Character Player { get { return player; } }
    private void Awake()
    {
        if(Instance == null)
            Instance = this;

        SetData();

    }


    public void SetData()
    {
        player = new Character();

        player.Additem(new Item(10,0,0,25, sword));
        player.Additem(new Item(0,5,0,25, shield));
        player.Additem(new Item(10,0,50,25, armor));
        player.Additem(new Item(10,0,50,25, null));
        player.Additem(new Item(10,0,50,25, null));
    }
}
