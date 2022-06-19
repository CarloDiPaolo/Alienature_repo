using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger_ObjectActivator : MonoBehaviour
{
    public GameObject target;
    
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) 
    {
        target.SetActive(true);
    }
}
