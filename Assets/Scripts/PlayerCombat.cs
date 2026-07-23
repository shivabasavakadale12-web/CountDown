using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

 [SerializeField] LayerMask mask;

    float radius = 0.7f;

    public void enemydamage()
    {
     Collider2D damagearea = Physics2D.OverlapCircle(this.transform.position, radius, mask);

        if (damagearea != null )
        {
            EnemyHealth enemy = damagearea.GetComponent<EnemyHealth>();
            enemy.takedamage(1);
        }
    }
}
