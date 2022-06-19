using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger_ObjectActivator : MonoBehaviour
{
    public GameObject target;
    public float delay;
    
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) 
    {
        Invoke("SpawnTarget", delay);
    }

    private void SpawnTarget()
    {
        target.SetActive(true);
    }
}
