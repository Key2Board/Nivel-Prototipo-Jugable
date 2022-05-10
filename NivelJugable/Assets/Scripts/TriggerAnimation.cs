using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    public GameObject Player;
    int i = 0;
    private void Update()
    {
        i++;
        if (i > 1000000)
        {
            if (Input.GetButtonDown("NewIdle"))
            {
                Player.GetComponent<Animator>().Play("NewIdle");
            }
        }
    }
}
