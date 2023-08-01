using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    [SerializeField] private GameObject[] enemys;
    [SerializeField] private GameObject[] doors;
    [SerializeField] private bool[] playerIsInTheRoom;
    public float activeEnemys;

    private void AllPlayerAreInTheRoom()
    {
        foreach(GameObject door in doors)
        {
            door.SetActive(true);
        }

        foreach (GameObject enemy in enemys)
        {
            activeEnemys += 0.5f;
            enemy.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out InputManager inputManager))
        {
            playerIsInTheRoom[inputManager.numOfPlayer - 1] = true;
            if (playerIsInTheRoom[0] && playerIsInTheRoom[1])
            {
                AllPlayerAreInTheRoom();
            }
            if (playerIsInTheRoom[0] && playerIsInTheRoom[1])
            {
                AllPlayerAreInTheRoom();
            }

        }
    }

    public void EnemyDied()
    {
        activeEnemys--;
        if (activeEnemys < 1)
        {
            foreach (GameObject door in doors)
            {
                door.SetActive(false);
            }
        }
    }
}
