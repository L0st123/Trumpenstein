using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;
using UnityEngine.UI;
public class EnemyAttack : MonoBehaviour
{
    public float enemyHealth; 
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
   
    int waypointIndex;
    Vector3 target;
    public Transform[] waypoints;
         
    public CapsuleCollider capsuleCollider;
   
    public static EnemyAttack instance;

    public GameObject enemyGameObject;
    
    private void Start()
    {
        
            UpdateDestination();
        
         enemyHealth = 100;

        animator.Play("Idle");
         
       


        animator = GetComponent<Animator>();  
      animator.SetBool("Walk", false);
        
    }
    private void Awake()
    {
        instance = this;
        player = GameObject.Find("PlayerBody").transform;
        agent = GetComponent<NavMeshAgent>();

    }

    private void Update()
    {
        
        IterateWaypointIndex();
      
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        //  if (!playerInSightRange || !playerInAttackRange) Patrolling();
        //  if (playerInSightRange ||  !playerInAttackRange) ChasePlayer();
        if (playerInSightRange || playerInAttackRange) { AttackPlayer(); }
        if (enemyHealth > 0)
        {
            if (!playerInAttackRange)
            {
                if (!agent.pathPending && !agent.hasPath && agent.remainingDistance < 0.1f)
                {
                    IterateWaypointIndex();
                    UpdateDestination();
                }
            }
        }
        else
        {

        }
            




    }
    void UpdateDestination()
    {
        animator.SetBool("Walk", true);
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);
    }
    void IterateWaypointIndex()
    {
        waypointIndex++;
        if (waypointIndex == waypoints.Length)
        {

            waypointIndex = 0;
        }
        

    }
   /// <BROKENATM>
  /*  private void SearchWalkPoint()
     {
        Debug.Log("searching");
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x +randomX, transform.position.y, transform.position.z + randomZ);
        //checks if in map
        if (Physics.Raycast(walkPoint, -transform.up, 2f,whatIsGround))
            walkPointSet = true;    
    }
    private void ChasePlayer()
    {
        Debug.Log("player located, chasing");
        animator.SetBool("Walk", true);
        return;
        
    }
  */
    
    private void AttackPlayer()
    {

        if (enemyHealth > 0)
        {


            if (!alreadyAttacked)
            {

                //attack
                animator.SetBool("Walk", false);

                PlayerMove.instance.DoDamage(5);

                animator.SetTrigger("Attack");
                Debug.Log("attacking");



                alreadyAttacked = true;
                Invoke(nameof(ResetAttack), timeBetweenAttacks);
            }
        }
        else
        {
            return;
        }
      

    }

    private void ResetAttack()
    {
        alreadyAttacked = false;
    }

    public void TakeDamage(int damage)
    {
        
        enemyHealth -= damage;

        if (enemyHealth <= 0)
        {


            ScoreCollect.scoreValue += 300;
             
            animator.SetTrigger("Dead");
            
            Destroy(capsuleCollider);


            
            
            
        }
    }



}
