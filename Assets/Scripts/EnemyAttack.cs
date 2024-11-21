using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;

public class EnemyAttack : MonoBehaviour
{
    public float health; 
    public NavMeshAgent agent;
    public Transform player;
    public LayerMask whatIsGround, whatIsPlayer;

    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    public float timeBetweenAttacks;
    bool alreadyAttacked;

    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;
    public Animator animator;

    private void Start()
    {
      animator = GetComponent<Animator>();  
      animator.SetBool("Walk", false);
    }
    private void Awake()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();

    }

    private void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        if (!playerInSightRange || !playerInAttackRange) Patrolling();
        if (playerInSightRange ||  !playerInAttackRange) ChasePlayer();
        if (playerInSightRange || playerInAttackRange) AttackPlayer();  
    }
    private void Patrolling()
    {
        animator.SetBool("Walk", true);
        if (!walkPointSet) SearchWalkPoint();
        if (walkPointSet)
            agent.SetDestination(walkPoint);

        Vector3 distanceToWalkPoint = transform.position - walkPoint;  

        if (distanceToWalkPoint.magnitude <1f)
            walkPointSet = false;   
    }
    private void SearchWalkPoint()
     {
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x +randomX, transform.position.y, transform.position.z + randomZ);
        //checks if in map
        if (Physics.Raycast(walkPoint, -transform.up, 2f,whatIsGround))
            walkPointSet = true;    
    }
    private void ChasePlayer()
    {
        animator.SetBool("Walk", true);
        agent.SetDestination(player.position);
    }
    private void AttackPlayer()
    {
        agent.SetDestination(transform.position);

        transform.LookAt(player);
        if (!alreadyAttacked)
        {

            //attack


            animator.SetTrigger("Attack");
            






            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }

    }

    private void ResetAttack()
    {
        alreadyAttacked = false;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            animator.SetTrigger("Dead");
            
        }
    }



}
