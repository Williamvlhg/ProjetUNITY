using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    [SerializeField] private RoomManager roomManager;
    private float PVEnemy = 10f;
    [SerializeField] private GameObject Enemi;
    public enum EnemyState
    {
        Chase,
        Attack
    }
    [SerializeField] private EnemyState currentState;

    private void Chase()
    {

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
        }
        
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
