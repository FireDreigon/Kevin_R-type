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
    public static int AtkBullet(BulletType bulletType)
    {
        switch (bulletType)
        {
            case BulletType.Basic:
                return 1;

            case BulletType.MaxType:
            default:
                return -1;
        }
    } 
    public static float ChargeBeamBullet(BulletType bulletType)
    {
        switch (bulletType)
        {
            case BulletType.Basic:
                return 1.5f;

            case BulletType.MaxType:
            default:
                return -1;
        }
    }


}
