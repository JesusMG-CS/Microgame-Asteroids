using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject asteroidPrefab;
    public float spawnRatePerMinute = 30f;
    public float spawnRateIncreasement = 1f;
    public float xlimit;
    public float maxTimeLife = 4f;
    
    
    private float spawnNext = 0;

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnNext)
        {
            spawnNext = Time.time + 60 / spawnRatePerMinute;
            spawnRatePerMinute+=spawnRateIncreasement;

            float rand = Random.Range(-xlimit,xlimit);
            Vector2 spawnPosition = new Vector2(rand,26.54f);
            GameObject meteor = Instantiate(asteroidPrefab,spawnPosition,Quaternion.identity);

            Destroy(meteor, maxTimeLife);
        }
        
    }
}
