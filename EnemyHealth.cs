using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int Health;
    //This detects if it collides with a bullets collision box
    void OnTriggerEnter(Collider PlayerBulletPrefab)
    {
        //This will remove 1 from the health int
        Health--;
        //This debug is just for testing and is only temporary
        Debug.Log(Health);
        //This will check if the health is at zero after every hit and see if the enemy needs destroying
        if(Health == 0)
        {
            //This destroys the enemy object
            Destroy(gameObject);
        }
    }
}
