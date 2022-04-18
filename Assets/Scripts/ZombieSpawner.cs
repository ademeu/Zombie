using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] objectPrefabs;
    [SerializeField] private Transform randomSpawnParent;

    private float currentTime;
    private int counter = 0;


    private void Update()
    {
        currentTime += Time.deltaTime;
        RandomSpawn(counter++);
    }


    void RandomSpawn(int counter)
    {
        if (counter >= 10) return;

        float randomX = Random.Range(-14, 14);
        float randomZ = Random.Range(-14, 14);

        for (int i = 0; i < 1; i++)
        {
            Instantiate(objectPrefabs[0], new Vector3(randomX, 1, randomZ), Quaternion.identity, randomSpawnParent);
            objectPrefabs[0].GetComponent<Rigidbody>().velocity = Vector3.up;
        }
        
    }
}
