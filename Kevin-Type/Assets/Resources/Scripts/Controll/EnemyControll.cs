using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class EnemyControll : MonoBehaviour {

    private Enemy enemyBaseStats= new Enemy(EnemyType.Stalker);
    private bool switchDir;
    private float switchTime;
    private GameObject Objective;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        switchTime += Time.deltaTime;
        switch (enemyBaseStats.Type)
        {
            case EnemyType.Basic:
                if (switchDir)
                    transform.Translate(Vector3.up * enemyBaseStats.Speed * Time.deltaTime);
                else
                    transform.Translate(-Vector3.up * enemyBaseStats.Speed * Time.deltaTime);

                if (switchTime >= Random.Range(0.3f, 0.6f))
                {
                    switchDir = !switchDir;
                    switchTime = 0;
                }

                transform.Translate(-Vector3.right * enemyBaseStats.Speed * Time.deltaTime);
                break;

            case EnemyType.Stalker:

                if (!Objective)
                {
                    print("buscando");
                    transform.Translate(-Vector3.right * enemyBaseStats.Speed * Time.deltaTime);
                    Collider2D[] TempObj = Physics2D.OverlapCircleAll(transform.position, 3); 
                    if(TempObj.Length>0)
                    foreach (var player in TempObj)
                        if (player.CompareTag("Player"))
                            Objective = player.transform.gameObject;
                        else
                            print("Hay pero no se reconoce");
                }
                else
                    transform.position = Vector3.MoveTowards(transform.position, Objective.transform.position, enemyBaseStats.Speed * Time.deltaTime);
                    break;
        }
    }
}
