using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager
{


    public List<GameObject> SetAllEnemys()
    {
        GameObject[] NewEnemys = Resources.LoadAll<GameObject>("Prefabs/Enemys");
        List<GameObject> NewEnemysList = new List<GameObject>();
        foreach (var Enemy in NewEnemys)
        {
            NewEnemysList.Add(Enemy);
        }
        return NewEnemysList;
    }
    public List<GameObject> SetAllEnemysByTypes(List<EnemyType> types)
    {
        GameObject[] NewEnemys = Resources.LoadAll<GameObject>("Prefabs/Enemys");
        List<GameObject> NewEnemysList = new List<GameObject>();
        foreach (var Enemy in NewEnemys)
        {
            if (types.Contains(Enemy.GetComponent<EnemyControll>().enemyType))
                NewEnemysList.Add(Enemy);
        }
        return NewEnemysList;
    }
}
