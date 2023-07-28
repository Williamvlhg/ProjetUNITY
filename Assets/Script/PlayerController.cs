using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 direction;
    [SerializeField] private Rigidbody2D rb;

    public void Move(Vector2 moveTo)
    {
        direction = moveTo;
        rb.velocity = new Vector2(direction.x, direction.y);
    }
}
