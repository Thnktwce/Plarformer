using UnityEngine;

public class Attck : MonoBehaviour
{
    public int attackDamage = 10;
    public Vector2 knockback = Vector2.zero;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Damageble damageble = collision.GetComponent<Damageble>();
        if(damageble != null)
        {
            Vector2 deliveredKnockback = transform.parent.localScale.x > 0 ? knockback : new Vector2(knockback.x, knockback.y);
           bool gotHit = damageble.Hit(attackDamage, knockback);
        }
    }
}
