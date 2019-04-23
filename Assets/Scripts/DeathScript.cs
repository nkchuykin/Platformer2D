using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour {

    private float downDeathBorder = -6f;
    public Animator animator;

    void Update () {
        if (animator.GetInteger("State") > 2)
            return;
        if (transform.position.y < downDeathBorder)
        {
            Death();
        }
    }

    public void Death()
    {
        animator.SetBool("GameStarted", false);
        animator.SetInteger("State", 3);
        Invoke("Restart", 0.75f);
    }

    void Restart()
    {
        animator.SetInteger("State", 0);
        CheckPointScript.flag = true;
    }

    void GoToCheckPoint()
    {
        
    }
}
