using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BulletType { Basic, MaxType }
[System.Serializable]
public class Bullet
{ 

    public int Atk;
    public int Speed;
    public int DeadTime;
    public BulletType bulletType; 

    public Bullet(int Atk, int Speed, int type)
    {

    } 
    public Bullet(BulletType bulletType)
    {
        switch (bulletType)
        {
            case BulletType.Basic:
                Atk = 1;
                Speed = 7;
                DeadTime = 5; 
                this.bulletType = bulletType;
                break;
            case BulletType.MaxType:
                break;

        }
    }


}
