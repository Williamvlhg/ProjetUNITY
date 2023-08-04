using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    [SerializeField] private RoomManager roomManager;
    private float PVEnemy = 10f;
    [SerializeField] private GameObject Enemi;
    private bool playerInSight;
    private Transform player;
    [SerializeField] private Rigidbody rb;
    [SerializeField] public float speed;
    [SerializeField] public HpManager hpManager;

    public enum EnemyState
    {
        Chase,
        Attack
    }
    [SerializeField] private EnemyState currentState;

    private void Chase()
    {
        if ((playerInSight) && (Vector3.Distance(transform.position, player.position) > 2))
        {
            transform.LookAt(player.transform.position);
            rb.velocity = transform.forward * speed;

        }
    }
    private void Attack()
    {

    }

    private void CheckForState()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Bullet"))
        {
            PVEnemy -= 2f;
            if(PVEnemy < 0)
            {
                EnemyDie();
                roomManager.EnemyDied();            
            }
        } else if (other.CompareTag("Player1"))
        {
         
                
                    hpManager.LoseHP1();
                
        }
        else if (other.CompareTag("Player2"))
        {
            hpManager.LoseHP2();
        }

        if (other.GetComponent<PlayerController>() != null)
        {
            player = other.transform;
            playerInSight = true;
        }
        else playerInSight = false;

    }


    private void EnemyDie()
    {
        Enemi.SetActive(false);
    }


    private void Update()
    {
        CheckForState();
        switch (currentState)
        {
            case EnemyState.Chase:
                Chase();
                break;
            case EnemyState.Attack:
                Attack();
                break;
        }
        
        
    }
}
