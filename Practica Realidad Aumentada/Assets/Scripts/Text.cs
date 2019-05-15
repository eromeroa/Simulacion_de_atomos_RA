using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    private TextMesh text;
    public GameObject textObj;
    public int nProtons;
    public int nNeutrons;
    public int nElectrons;
    public float AtomicW;
    public string Atom;
    // Start is called before the first frame update
    void Start()
    {
        text = textObj.GetComponent<TextMesh>();
        text.text = "<b><color=#000000ff>" + Atom+ "</color></b>\n<color=#ff0000ff>Número de protones: " + nProtons+"</color>\n<color=#ffff00ff>Número de neutrones: "+nNeutrons+"</color>\n<color=#0000a0ff>Número de electrones: "+nElectrons+"</color>\nPeso atómico: "+AtomicW+" u";
        textObj.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I) && !textObj.gameObject.activeInHierarchy)
        {
            textObj.gameObject.SetActive(true);
        }
        else if(Input.GetKeyDown(KeyCode.I) && textObj.gameObject.activeInHierarchy)
        {
            textObj.gameObject.SetActive(false);
        }
    }
}
