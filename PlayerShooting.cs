using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject PlayerBulletPrefab;
    public Transform FirePlace;
    public Transform FirePlace2;
    public float BulletForce;
    public float repeatRate;
    public bool ExtraFirePlace;

    void Start()
    {
        InvokeRepeating("Fire", .3f, repeatRate);
    }
    
    void Fire()
    {
        //This creates the bullet at the FirePlace on the player and orients it
        GameObject Bullet = Instantiate(PlayerBulletPrefab, FirePlace.position, FirePlace.rotation);
        //This gives it a RigidBody and a collision box
        Rigidbody rb = Bullet.GetComponent<Rigidbody>();
        //This Adds force to the bullet so it can move forwards
        //The different types of forces you can add effect how force speed off over time
        rb.AddForce(FirePlace.forward * BulletForce, ForceMode.Impulse);
        //This destroys the bullet after a set amount of time if it doesn't hit 
        Destroy(Bullet, 1f);
        
        if(ExtraFirePlace == true) 
        {
            //This creates the bullet at the FirePlace on the player and orients it
            GameObject Bullet2 = Instantiate(PlayerBulletPrefab, FirePlace2.position, FirePlace2.rotation);
            //This gives it a RigidBody and a collision box
            Rigidbody rb2 = Bullet2.GetComponent<Rigidbody>();
            //This Adds force to the bullet so it can move forwards
            //The different types of forces you can add effect how force speed off over time
            rb2.AddForce(FirePlace2.forward * BulletForce, ForceMode.Impulse);
            //This destroys the bullet after a set amount of time if it doesn't hit 
            Destroy(Bullet, 1f);
        }
    }
}
