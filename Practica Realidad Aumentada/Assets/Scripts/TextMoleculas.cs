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
    private GameObject molecula;
    Touch touch;

    // Start is called before the first frame update
    void Start()
    {
        text = textObj.GetComponent<TextMesh>();
        text.text = "<color=#000000ff><b>" + nombreMolecula + "</b></color>\n<color=#00ff00ff>Fórmula química: " + formula + "</color>\n<color=#800080ff>Estado a temperatura ambiente: " + estadoTempAmbiente + "</color>\n";
        textObj.gameObject.SetActive(false);
        molecula = transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        touch = Input.GetTouch(0);
        if ((molecula.gameObject.activeInHierarchy && Input.GetKeyDown(KeyCode.I) && !textObj.gameObject.activeInHierarchy) || (molecula.gameObject.activeInHierarchy && touch.phase == TouchPhase.Began && !textObj.gameObject.activeInHierarchy))
        {
            textObj.gameObject.SetActive(true);
        }
        else if ((molecula.gameObject.activeInHierarchy && Input.GetKeyDown(KeyCode.I) && textObj.gameObject.activeInHierarchy) || (molecula.gameObject.activeInHierarchy && touch.phase == TouchPhase.Began && textObj.gameObject.activeInHierarchy))
        {
            textObj.gameObject.SetActive(false);
        }
    }
}