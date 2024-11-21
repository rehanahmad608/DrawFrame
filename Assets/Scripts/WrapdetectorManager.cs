using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrapdetectorManager : MonoBehaviour
{
    public List<Wrapdetector> wrapdetectors = new List<Wrapdetector>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenAll()
    {
        foreach(Wrapdetector wrapdetector in wrapdetectors)
        {
            wrapdetector.Open();
        }
    }
    public void CloseAll()
    {
        foreach(Wrapdetector wrapdetector in wrapdetectors)
        {
            wrapdetector.Close();
        }
    }
}
