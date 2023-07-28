using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private PlayerController pc;
    [SerializeField] private int numOfPlayer;
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
    }
}
