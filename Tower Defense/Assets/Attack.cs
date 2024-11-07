using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if ()
        {
            if (anim != null)
            {
                anim.SetTrigger("isAttack");
            }
        }
    }
}
