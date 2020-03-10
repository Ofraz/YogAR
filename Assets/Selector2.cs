using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector2 : MonoBehaviour
{

    public GameObject Posicion1;
    public GameObject Posicion2;
    
    public int BallSelected;

    // Use this for initialization
    void Start()
    {
        Posicion1.SetActive(true);
        Posicion2.SetActive(false);
    }

    public void LoadPosicion1()
    {
        Posicion1.SetActive(true);
        Posicion2.SetActive(false);
       
    }

    public void LoadPosicion2()
    {
        Posicion1.SetActive(false);
        Posicion2.SetActive(true);
        
    }

   
}