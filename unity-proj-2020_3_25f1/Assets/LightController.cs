using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light R;
    public Light G;
    public Light B;

    public void ThreeOn()
    {
        R.enabled = true;
        G.enabled = true;
        B.enabled = true;
    }
    
    public void TwoOn()
    {
        R.enabled = true;
        G.enabled = true;
        B.enabled = false;
    }
    
    public void OneOn()
    {
        R.enabled = true;
        G.enabled = false;
        B.enabled = false;
    }

    public void AllOff()
    {
        R.enabled = false;
        G.enabled = false;
        B.enabled = false;
    }
}
