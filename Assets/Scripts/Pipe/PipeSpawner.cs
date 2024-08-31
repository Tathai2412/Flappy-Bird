using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float spawnTime = 2f;
    [SerializeField] private float minY, maxY;
    
    private float spawnPos;

    void Update()
    {
        Spawn();
    }


    private void Spawn()
    {
        spawnTime -= Time.deltaTime;
        spawnPos = Random.Range(minY, maxY);
        

        if (spawnTime <= 0)
        {
            Instantiate(pipePrefab, new Vector3(1.2f, -1.3f + spawnPos), Quaternion.identity);
            spawnTime = 1.5f;
        }
    }
}
