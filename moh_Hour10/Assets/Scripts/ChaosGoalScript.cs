using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaosGoalScript : GoalScript
{
    public int chaosCount = 8;
    
    void OnTriggerEnter (Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if (collidedWith.tag == gameObject.tag)
        {
            if (--chaosCount <= 0) 
            {
                isSolved = true;
                GetComponent<Light>().enabled = false;
            }
            Destroy (collidedWith);
        }
    }
}
