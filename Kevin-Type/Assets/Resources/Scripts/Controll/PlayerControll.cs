using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    
    private Player playerBaseStats = new Player(3, 5, 0.2f,BulletType.Basic);
    public Player currentplayerStats;
    public float DelayShoot;
    public GameObject Bullet;
    // Use this for initialization
    void Start()
    {
        currentplayerStats = playerBaseStats;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * currentplayerStats.Speed * Time.deltaTime);
        transform.Translate(Vector3.up * Input.GetAxis("Vertical") * currentplayerStats.Speed * Time.deltaTime);

        if (DelayShoot < currentplayerStats.DelayShoot * 2)
            DelayShoot += Time.deltaTime;

        if (transform.position.x >= 8.3f)
            transform.position = new Vector2(8.3f, transform.position.y);
        else if (transform.position.x <= -8.3f)
            transform.position = new Vector2(-8.3f, transform.position.y);
        if (transform.position.y >= 4.5f)
            transform.position = new Vector2(transform.position.x, 4.5f);
        else if (transform.position.y <= -3.7f)
            transform.position = new Vector2(transform.position.x, -3.7f);

        if (Input.GetKeyDown(KeyCode.Space))
            if (DelayShoot >= currentplayerStats.DelayShoot)
                Shoot();
    }

    public void Shoot()
    {
        Vector3 InstantiatePoint = transform.position;
        InstantiatePoint.x += 0.3f;
        GameObject newBullet = Instantiate(Bullet, InstantiatePoint, Quaternion.Euler(Vector3.zero));
        newBullet.GetComponent<BulletControll>().bulletBaseStats = new Bullet(currentplayerStats.bulletType);
        DelayShoot = 0;
    }
}
