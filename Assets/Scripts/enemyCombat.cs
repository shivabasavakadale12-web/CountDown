using UnityEngine;

public class enemyCombat : MonoBehaviour
{
   [SerializeField] LayerMask mask;

    float radius = 0.7f;

    public void playerdamage()
    {
        Collider2D playerdamagearea = Physics2D.OverlapCircle(this.transform.position, radius, mask);

        if (playerdamagearea != null)
        {
            PlayerHealth player = playerdamagearea.GetComponent<PlayerHealth>();
            player.Takedamage(1);
        }
    }
}
