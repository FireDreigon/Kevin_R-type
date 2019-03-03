using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player
{

    public string NamePlayer { get; set; }
    public SkinPlayer Skin;

    public int HP;
    public float Speed;
    public BulletType bulletType;
    public float DelayShoot;
    public float ChargeBeamTime;

    public Player (int hp, int speed, float delayShoot, BulletType bulletType)
    {
        HP = hp;
        Speed = speed;
        DelayShoot = delayShoot;
        this.bulletType = bulletType;
        ChargeBeamTime = Bullet.ChargeBeamBullet(this.bulletType);
    }

}
