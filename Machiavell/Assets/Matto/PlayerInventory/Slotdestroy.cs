using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slotdestroy : MonoBehaviour
{
    public Slotweapondeth swd;
    public Slotstatusdeth ssd;
    public Slotdethstar sds;
    public Slotread sr;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void Slotweapondestroy()
    {
        ssd.destroy();
        sds.dethstar();
        sr.destroyweapon();
        swd.OnClick();
    }
}
