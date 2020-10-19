using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangkapObjek : MonoBehaviour
{
    public GameObject bola;
    public GameObject tangan;

    bool tertangkap = false;
    Vector3 posisiBola;
    // Start is called before the first frame update
    void Start()
    {
        posisiBola = bola.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!tertangkap){
                bola.transform.SetParent(tangan.transform);
                // bola.transform.localPosition = tangan.transform.localPosition;
                bola.transform.localPosition = new Vector3(.02f, -.42f, .8f);
                tertangkap = true;
                bola.GetComponent<Renderer>().material.color = Color.blue;
            }
            else if (tertangkap){
                bola.transform.SetParent(null);
                bola.transform.localPosition = posisiBola;
                tertangkap = false;
                bola.GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }
}
