using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public int attack { get; private set; }
    public int defense { get; private set; }
    public float exp { get; private set; }
    public string nickname { get; private set; }
    public int gold { get; private set; }
    public int level { get; private set; }
    public float crit { get; private set; }
    public int health { get; private set; }
    public List<Item> Inventory = new List<Item>();

    public Character()
    {
        attack = 12;
        defense = 2;
        exp = 5;
        nickname = "Rtan";
        gold = 1;
        level = 3;
        crit = 16;
        health = 100;
    }

    public void Additem(Item item)
    {
        Inventory.Add(item);
    }

    public void Equip(Item item)
    {

    }

    public void UnEquip()
    {

    }
}
