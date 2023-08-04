using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float timeToExplode = 1f;
    private Vector3 direction;


    private void OnEnable()
    {
        StartCoroutine(BulletCD());
    }
    private IEnumerator BulletCD()
    {
        yield return new WaitForSeconds(timeToExplode);
        gameObject.SetActive(false);
    }

}
