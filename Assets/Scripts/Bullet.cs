using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 5;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out EnemyPlane plane))
        {
            plane.Hit(damage);
            Destroy(gameObject);
        }
    }
}
