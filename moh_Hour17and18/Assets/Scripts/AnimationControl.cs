using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S)) 
        {
            anim.SetTrigger("SpinTrigger");
        }
        if (Input.GetKey(KeyCode.D)) 
        {
            anim.SetTrigger("ScaleTrigger");
        }
        if (Input.GetKey(KeyCode.W)) 
        {
            anim.SetTrigger("HoverTrigger");
        }
        if (Input.GetKey(KeyCode.A)) 
        {
            anim.SetTrigger("ColorTrigger");
        }
    }
}
