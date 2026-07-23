using UnityEngine;

public class shield : MonoBehaviour
{
    const string player = "Player";

    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.tag == player)
        {
            Destroy(gameObject);
        }


    }
}
