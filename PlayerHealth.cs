using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int Health;
    public int damageTaken = 0;
    //This detects if it collides with a bullets collision box
    void OnTriggerEnter(Collider EnemyBulletPrefab)
    {
        //This will remove 1 from the health int and add 1 to damage taken
        Health--;
        damageTaken++;
        //This debug is just for testing and is only temporary
        Debug.Log(Health);
        //This will check if the health is at zero after every hit and see if the player needs destroying
        if (Health == 0)
        {
            //This destroys the player object
            Destroy(gameObject);
        }
    }
}
