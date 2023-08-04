using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HpManager : MonoBehaviour
{

    [SerializeField] private int hpP1 = 3;
    [SerializeField] private int hpP2 = 3;
    [SerializeField] private GameObject[] heartIconsP1;
    [SerializeField] private GameObject[] heartIconsP2;
    [SerializeField] private GameObject p1;
    [SerializeField] private GameObject p2;
    [SerializeField] private ScreenShake shake;



    public void LoseHP1()
    {
        hpP1--;
        heartIconsP1[hpP1].gameObject.SetActive(false);
        shake.StartShake();
        if (hpP1 < 1)
        {
            PlayerController p1Controller = p1.GetComponent<PlayerController>();
            InputManager p1Inputmanager = p1.GetComponent<InputManager>();
            p1Controller.enabled = false;
            p1Inputmanager.enabled = false;
            Rigidbody p1rb = p1.GetComponent<Rigidbody>();
            p1rb.constraints = RigidbodyConstraints.None;
            p1rb.AddForce(transform.forward * 2, ForceMode.Impulse);
        }
    }
    public void LoseHP2()
    {
        hpP2--;
        heartIconsP2[hpP2].gameObject.SetActive(false);
        shake.StartShake();
        if (hpP2 < 1)
        {
            PlayerController p2Controller = p2.GetComponent<PlayerController>();
            InputManager p2Inputmanager = p2.GetComponent<InputManager>();
            p2Controller.enabled = false;
            p2Inputmanager.enabled = false;
            Rigidbody p2rb = p2.GetComponent<Rigidbody>();
            p2rb.constraints = RigidbodyConstraints.None;
            p2rb.AddForce(transform.forward * 2, ForceMode.Impulse);
        }

    }
    private void FixedUpdate()
    {
        if (hpP1<1 && hpP2 < 1)
        {
            SceneManager.LoadScene(1);
        }

    }
}
