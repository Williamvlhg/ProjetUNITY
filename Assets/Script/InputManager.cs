using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private PlayerController pc;
    [SerializeField] public int numOfPlayer;
    [SerializeField] private GameObject menuPause;
    private Vector2 direction;

    private void GetDirection()
    {
        direction.x = Input.GetAxis("HorizontalP" + numOfPlayer);
        direction.y = Input.GetAxis("VerticalP" + numOfPlayer);
    }

    void Update()
    {
        GetDirection();
        pc.Move(direction);
        if (Input.GetButtonDown("FireP"+numOfPlayer))
        {
            pc.ShootBullet();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menuPause.SetActive(true);
        }
    }
}
