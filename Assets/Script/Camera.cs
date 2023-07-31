using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] public Transform player1;
    [SerializeField] public Transform player2;
    public float lerpSpeed = 1.0f;

    private Transform cameraTransform;

    private void Start()
    {
        cameraTransform = transform;
    }

    private void Update()
    {
        // Calculate the midpoint between the players
        Vector3 midpoint = (player1.position + player2.position) / 2.0f;

        // Move the camera to the midpoint at a fixed height above the players
        Vector3 targetPosition = midpoint + new Vector3(0f, 13f, -10f); // Adjust the height (Y) based on your game's needs
        cameraTransform.position = Vector3.Lerp(cameraTransform.position, targetPosition, lerpSpeed * Time.deltaTime);
    }
}
