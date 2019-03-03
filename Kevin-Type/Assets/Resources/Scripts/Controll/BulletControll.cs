using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControll : MonoBehaviour
{
    public Bullet bulletBaseStats;
    // Use this for initialization
    void Start()
    {
        Destroy(transform.gameObject, bulletBaseStats.DeadTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right *  bulletBaseStats.Speed * Time.deltaTime);
    }
}
