using UnityEngine;

public class Player
{
    private int hp = 100;
    private int power = 50;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Damage(int damage) 
    {
        this.hp -= damage;
        Debug.Log(damage + "のダメージを受けた");
    }
}

