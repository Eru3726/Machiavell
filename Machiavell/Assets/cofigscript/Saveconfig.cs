using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saveconfig : MonoBehaviour
{
    public Save saveClass;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void saveconfig()
    {
        saveClass.config = true;
        saveClass.enabled = true;
    }
}
