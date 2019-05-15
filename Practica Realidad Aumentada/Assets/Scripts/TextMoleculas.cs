using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMoleculas : MonoBehaviour
{
    private TextMesh text;
    public GameObject textObj;
    public string nombreMolecula;
    public string formula;
    public string estadoTempAmbiente;
    

    // Start is called before the first frame update
    void Start()
    {
        text = textObj.GetComponent<TextMesh>();
        text.text = "<color=#000000ff><b>" + nombreMolecula + "</b></color>\n<color=#00ff00ff>Fórmula química: " + formula + "</color>\n<color=#800080ff>Estado a temperatura ambiente: " + estadoTempAmbiente + "</color>\n";
        textObj.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && !textObj.gameObject.activeInHierarchy)
        {
            textObj.gameObject.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.I) && textObj.gameObject.activeInHierarchy)
        {
            textObj.gameObject.SetActive(false);
        }
    }
}