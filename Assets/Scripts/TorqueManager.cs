using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorqueManager : MonoBehaviour
{
    public List<Rigidbody> TorqueObjects = new List<Rigidbody>();
    // Start is called before the first frame update
    void Start()
    {
        StopAll();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartAll()
    {
        foreach(Rigidbody rb in TorqueObjects)
        {
            rb.isKinematic = false;
        }
    }
    public void StopAll()
    {
        foreach (Rigidbody rb in TorqueObjects)
        {
            rb.isKinematic = true;
        }
    }
}
