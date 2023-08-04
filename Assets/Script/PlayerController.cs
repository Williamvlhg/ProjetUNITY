using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 direction;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float stepForce;
    private Vector3 lastDirection;
    [SerializeField] private AudioClip shootSound;

    public void Move(Vector2 moveTo)
    {
        direction = moveTo;
        rb.velocity = new Vector3(direction.x * stepForce, 0, direction.y * stepForce);
    }
    public void ShootBullet()
    {
        SoundManager.instanceSound.PlaySound(shootSound);
        GameObject bullet = Instantiate(bulletPrefab, transform.position + transform.forward, Quaternion.Euler(90f, 0f, 0f));
        Rigidbody bulletrb = bullet.GetComponent<Rigidbody>();
        bulletrb.AddForce(transform.forward * 100, ForceMode.Impulse) ;
        BulletCD();
    }
    private IEnumerator BulletCD()
    {
        yield return new WaitForSeconds(2f);
        gameObject.SetActive(false);
    }

    public void GetRotation()
    {
        if (direction != Vector2.zero)
        {
            lastDirection = new Vector3(direction.x, 0f, direction.y);
            transform.forward = lastDirection; 
        }
    }

    private void Update()
    {
        GetRotation();
    }
}

