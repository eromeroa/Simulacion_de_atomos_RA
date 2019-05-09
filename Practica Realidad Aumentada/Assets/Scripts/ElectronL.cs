using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectronL : MonoBehaviour
{
    Renderer rend;
    public GameObject padre;
    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        velocidad = 35.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(padre.transform.position, padre.transform.up, velocidad * Time.deltaTime);
    }
}
