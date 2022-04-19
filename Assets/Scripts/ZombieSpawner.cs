using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ZombieSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _objectPrefabs;
    [SerializeField] private List<Transform> randomSpawnParent;
    [SerializeField] private int _spawnAmount;


    private void Start()
    {
        RandomSpawn();
    }

    void RandomSpawn()
    {
        int randomIndex = Random.Range(0, randomSpawnParent.Count);

        if (_spawnAmount > randomSpawnParent.Count)
        {
            _spawnAmount = randomSpawnParent.Count;
        }
        for (int i = 0; i < _spawnAmount ; i++)
        {
               Instantiate(_objectPrefabs, randomSpawnParent[randomIndex].position, Quaternion.identity, this.transform);
               var kullanilmisSpawnPoint = randomSpawnParent[randomIndex];
               
                randomSpawnParent.Remove(kullanilmisSpawnPoint);
                Debug.Log(randomSpawnParent.Count);
        }
    }
}
