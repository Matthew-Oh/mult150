using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        print(this.gameObject.name + " triggered enter");
    }

    void OnTriggerStay(Collider other)
    {
        print(this.gameObject.name + " triggered stay");
    }

    void OnTriggerExit(Collider other)
    {
        print(this.gameObject.name + " triggered exit");
    }
}
