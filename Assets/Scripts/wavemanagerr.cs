using UnityEngine;

public class wavemanagerr : MonoBehaviour
{

    [SerializeField] GameObject enemy;
    public int enemydeathcounter = 0;

    float spawneroffestx;
    float spawneroffesty;
    public static wavemanagerr instance;

     void Awake()
    {
        instance = this;
    }

     void Start()
    {
        enemywaves(6);
    }

    public void enemywaves(int count)
    {
        for (int i = 0; i < count; i++)
        {
        spawneroffestx = Random.Range(-20f, 20f);
        spawneroffesty = Random.Range(-4f, 3f);

            Vector2 spawnpos = new Vector2(transform.position.x + spawneroffestx, transform.position.y + spawneroffesty);

            Instantiate(enemy, spawnpos, Quaternion.identity);
        }

    }
  
    public void enemydied()
    {
        enemydeathcounter++;

        if (enemydeathcounter == 6)
        {
            enemywaves(8);
        }

        if (enemydeathcounter == 14)
        {
            enemywaves(10);
        }
    }

}
