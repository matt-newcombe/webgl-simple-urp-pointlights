using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public MeshRenderer cubeRenderer;
    public List<MeshRenderer> earthRenderers;
    
    public Material litMat;
    public Material simpleLitMat;
    
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

    public void LitMaterial()
    {
        cubeRenderer.sharedMaterial = litMat;

        foreach (var earthRen in earthRenderers)
        {
            earthRen.sharedMaterial = litMat;
        }
    }
    
    public void SimpleLitMaterial()
    {
        cubeRenderer.sharedMaterial = simpleLitMat;
        
        foreach (var earthRen in earthRenderers)
        {
            earthRen.sharedMaterial = simpleLitMat;
        }
    }

    public void BtnEarthModel()
    {
        cubeRenderer.enabled = false;
        
        foreach (var earthRen in earthRenderers)
        {
            earthRen.enabled = true;
        } 
    }

    public void BtnCubeModel()
    {
        cubeRenderer.enabled = true;
        
        foreach (var earthRen in earthRenderers)
        {
            earthRen.enabled = false;
        }   
    }
}
