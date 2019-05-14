using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMolecule : MonoBehaviour
{
    public GameObject tarjeta;
    private GameObject molecula;
    private GameObject atomo1;
    private GameObject atomo2;

    // Start is called before the first frame update
    void Start()
    {
        molecula = transform.GetChild(1).gameObject;
        atomo1 = transform.GetChild(0).gameObject;
        atomo2 = tarjeta.transform.GetChild(0).gameObject;
        molecula.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(transform.position, tarjeta.transform.position);

        if (dist < 20 && !molecula.gameObject.activeInHierarchy)
        {
            atomo1.gameObject.SetActive(false);
            atomo2.gameObject.SetActive(false);
            molecula.gameObject.SetActive(true);

        }
        else if(dist > 20 && molecula.gameObject.activeInHierarchy)
        {
            atomo1.gameObject.SetActive(true);
            atomo2.gameObject.SetActive(true);
            molecula.gameObject.SetActive(false);

        }
    }
}
