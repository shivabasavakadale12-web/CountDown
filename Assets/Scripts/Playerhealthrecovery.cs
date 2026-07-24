using UnityEngine;

public class Playerhealthrecovery : MonoBehaviour
{
    const string player = "Player";

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag ==  player)
        {
            if(PlayerHealth.instance.health != 10f)
            {
                PlayerHealth.instance.health = 10f;
            }

            Destroy(gameObject);
        }

    }
}
