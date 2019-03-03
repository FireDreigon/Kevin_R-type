using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private float TimeGame=0;
    private int PlayerLife = 2;
    private int Score=18546;
    private int Coins;
    private float SpawnTime = 2;
    private float currentSpawnTime;
    public SpawnManager spawnManager = new SpawnManager();
    private List<GameObject> allEnemysInThisLv;
    public List<EnemyType> allEnemysTypeInThisLv;

    public PlayerControll Player; 
    [HideInInspector]
    public HUDManager _HUDManager= new HUDManager();
	// Use this for initialization
	void Start () {

        _HUDManager.Start(Player.currentplayerStats);
        allEnemysInThisLv = spawnManager.SetAllEnemysByTypes(allEnemysTypeInThisLv);
        _HUDManager.UpdateScore(Score);

        Player.gameManager = this;

    }
	
	// Update is called once per frame
	void Update ()
    {
        TimeGame += Time.deltaTime;
        currentSpawnTime += Time.deltaTime;
        _HUDManager.UpdateTime(TimeGame);
        if(currentSpawnTime>= SpawnTime)
        {
            Vector2 NewInstantiatePoint = new Vector2(12, Random.Range(-2.5f, 4));
            Instantiate(allEnemysInThisLv[Random.Range(0, allEnemysInThisLv.Count)], NewInstantiatePoint, Quaternion.Euler(Vector3.zero));
            currentSpawnTime = 0;
        }

    }
}
