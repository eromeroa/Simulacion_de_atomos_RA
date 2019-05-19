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
    public string caracteristicas;
    public string caracteristicas2;
    public string caracteristicas3;
    private GameObject molecula;
    Touch touch;

    // Start is called before the first frame update
    void Start()
    {
        text = textObj.GetComponent<TextMesh>();
        text.text = "<b><size=180><color=#000000ff>" + nombreMolecula + "</color></size>\n<color=#00ff00ff>Fórmula química: " + formula + "</color>\n<color=#800080ff>Estado a temperatura ambiente: " + estadoTempAmbiente + "</color>\nCaracterísticas: \n<color=#0066ff>"+ caracteristicas + "\n" + caracteristicas2 + "\n" + caracteristicas3 + "</color></b>";
        textObj.gameObject.SetActive(false);
        molecula = transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        touch = Input.GetTouch(0);
        //if (molecula.gameObject.activeInHierarchy && Input.GetKeyDown(KeyCode.I) && !textObj.gameObject.activeInHierarchy)
        if (molecula.gameObject.activeInHierarchy && touch.phase == TouchPhase.Began && !textObj.gameObject.activeInHierarchy)
        {
            textObj.gameObject.SetActive(true);
        }
        //else if (molecula.gameObject.activeInHierarchy && Input.GetKeyDown(KeyCode.I) && textObj.gameObject.activeInHierarchy)
        else if (molecula.gameObject.activeInHierarchy && touch.phase == TouchPhase.Began && textObj.gameObject.activeInHierarchy)
        {
            textObj.gameObject.SetActive(false);
        }
    }
}