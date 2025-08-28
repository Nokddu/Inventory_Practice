using UnityEngine;
using UnityEngine.UI;

public class Item
{
    public int attack { get; private set; }
    public int defense { get; private set; }
    public int health {  get; private set; }
    public float crit {  get; private set; }
    public Sprite icon {  get; private set; }

    public Item(int atk, int def, int hp,float crt, Sprite ic)
    {
        attack = atk;
        defense = def;
        health = hp;
        crit = crt;
        icon = ic;
    }
}
