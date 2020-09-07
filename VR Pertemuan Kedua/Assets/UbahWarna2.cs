using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UbahWarna2 : MonoBehaviour
{
    // Start is called before the first frame update
    public void Hijau()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }

    public void Putih()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }

    public void Cyan()
    {
        GetComponent<Renderer>().material.color = Color.cyan;
    }
}
