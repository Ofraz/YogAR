using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour
{

    public GameObject Posicion1;
    public GameObject Posicion2;
    public GameObject Posicion3;

    public int BallSelected;

    // Use this for initialization
    void Start()
    {
        Posicion1.SetActive(true);
        Posicion2.SetActive(false);
        Posicion3.SetActive(false);

    }

    public void LoadPosicion1()
    {
        Posicion1.SetActive(true);
        Posicion2.SetActive(false);
        Posicion3.SetActive(false);
    }

    public void LoadPosicion2()
    {
        Posicion1.SetActive(false);
        Posicion2.SetActive(true);
        Posicion3.SetActive(false);
    }

    public void LoadPosicion3()
    {
        Posicion1.SetActive(false);
        Posicion2.SetActive(false);
        Posicion3.SetActive(true);
    }
}