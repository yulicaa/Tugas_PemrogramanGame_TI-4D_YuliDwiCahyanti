using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UbahWarna3 : MonoBehaviour
{
    public void Kuning()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
    }

    public void Abu()
    {
        GetComponent<Renderer>().material.color = Color.grey;
    }

    public void Magenta()
    {
        GetComponent<Renderer>().material.color = Color.magenta;
    }
}

