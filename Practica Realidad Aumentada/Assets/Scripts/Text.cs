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
    private GameObject atomo;
    Touch touch;
    // Start is called before the first frame update
    void Start()
    {
        text = textObj.GetComponent<TextMesh>();
        text.text = "<b><size=180><color=#000000ff>" + Atom+ "</color></size>\n<color=#ff0000ff>Número de protones: " + nProtons+"</color>\n<color=#ffff00ff>Número de neutrones: "+nNeutrons+"</color>\n<color=#0000a0ff>Número de electrones: "+nElectrons+"</color>\nPeso atómico: "+AtomicW+" u</b>";
        textObj.gameObject.SetActive(false);
        atomo = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        touch = Input.GetTouch(0);
        if((atomo.gameObject.activeInHierarchy && Input.GetKeyDown(KeyCode.I) && !textObj.gameObject.activeInHierarchy) || (atomo.gameObject.activeInHierarchy && touch.phase == TouchPhase.Began && !textObj.gameObject.activeInHierarchy))
        {
            textObj.gameObject.SetActive(true);
        }
        else if((atomo.gameObject.activeInHierarchy && Input.GetKeyDown(KeyCode.I) && textObj.gameObject.activeInHierarchy) || (atomo.gameObject.activeInHierarchy && touch.phase == TouchPhase.Began && textObj.gameObject.activeInHierarchy))
        {
            textObj.gameObject.SetActive(false);
        }
    }
}
