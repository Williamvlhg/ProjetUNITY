using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
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
