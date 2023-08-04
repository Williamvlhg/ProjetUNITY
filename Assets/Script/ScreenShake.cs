using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    private bool isShaking;
    private Vector3 originalPosition;
    [SerializeField] private CameraManager cameraManager;
    [SerializeField] private float duration = 0.3f;
    [SerializeField] private float shakeMagnitude = 0.3f;
    private float shakeTime;
    [ContextMenu("StartShake")]
    public void StartShake()
    {
        isShaking = true;
        originalPosition = transform.position;
        cameraManager.enabled = false;
        shakeTime = duration; 
    }

    private void Shake()
    {
        if (isShaking)
        {
            transform.position = originalPosition + Random.insideUnitSphere * shakeMagnitude;
            shakeTime -= Time.deltaTime;

        }
        if(shakeTime <= 0)
        {
            transform.position = originalPosition;
            cameraManager.enabled = true;
            isShaking = false;
        }
    }

    private void FixedUpdate()
    {
        if (!isShaking) return;
        Shake();
    }
}
