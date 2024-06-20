using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer;

    //Attacking
    public float attackSpeed;

    //When the script is ran it will get the NavMesh and find the players location
    private void Awake()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }
    //Every frame the enemy will run this
    private void Update()
    {
        ChasePlayer();
    }

    //This first sets the targer to the player
    //It then looks at the player
    private void ChasePlayer()
    {
        agent.SetDestination(player.position);

        transform.LookAt(player);
    }
}
