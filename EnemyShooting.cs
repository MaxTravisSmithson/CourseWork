using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject EnemyBulletPrefab;
    public Transform FirePlace;
    public float BulletForce;
    public float repeatRate;

    void Start()
    {
        InvokeRepeating("Fire", .3f, repeatRate);
    }

    void Fire()
    {
        //This creates the bullet at the FirePlace on the enemy and orients it
        GameObject Bullet = Instantiate(EnemyBulletPrefab, FirePlace.position, FirePlace.rotation);
        //This gives it a RigidBody and a collision box
        Rigidbody rb = Bullet.GetComponent<Rigidbody>();
        //This Adds force to the bullet so it can move forwards
        //The different types of forces you can add effect how force speed off over time
        rb.AddForce(FirePlace.forward * BulletForce, ForceMode.Impulse);
        //This destroys the bullet after a set amount of time if it doesn't hit 
        Destroy(Bullet, 1f);
    }
}
