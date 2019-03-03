using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum EnemyType { Basic, Stalker, MaxEnemyType }
[System.Serializable]
public class Enemy
{
    
    public int HP;
    public int Atk;
    public float Speed;
    public EnemyType Type;
    public float DelayShoot;

    public Enemy(int hp, int atk, int speed)
    {
        HP = hp;
        Atk = atk;
        Speed = speed;
    }

    public Enemy(EnemyType type)
    {
        Type = type;
        switch (type)
        {
            case EnemyType.Basic:

                HP = 1;
                Atk = 1;
                Speed = 3;
                
                break;

            case EnemyType.Stalker:

                HP = 1;
                Atk = 1;
                Speed = 5.5f;

                break;

        }
    }
}
