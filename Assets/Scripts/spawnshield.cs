
using UnityEngine;

public class spawnshield : MonoBehaviour
{
    [SerializeField] GameObject shield;
    [SerializeField] GameObject Player;
    [SerializeField] float timertospawn = 8f;

    float posx;
    float posy;

    Vector2 spawnpos;

    private void Start()
    {
       posx = transform.position.x + Random.Range(-3f, 3f);

        posy = transform.position.y + Random.Range(-5f, 7f);
        InvokeRepeating("Spawn", timertospawn, timertospawn);
    }

     void Spawn()
    {
     Vector2 playerpos = Player.transform.position;
              spawnpos = new Vector2( playerpos.x + posx,playerpos.y + posy);
        Instantiate(shield, spawnpos, Quaternion.identity);
       
    }

}
