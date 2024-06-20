using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //Destroy the bullet
        Destroy(gameObject);
    }
}
