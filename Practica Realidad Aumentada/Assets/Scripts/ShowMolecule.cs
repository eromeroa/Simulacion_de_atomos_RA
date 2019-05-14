using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMolecule : MonoBehaviour
{
    public GameObject tarjeta1;
    public GameObject tarjeta2;
    public GameObject molecula;
    public GameObject atomo1;
    public GameObject atomo2;

    // Start is called before the first frame update
    void Start()
    {
        molecula.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(tarjeta1.transform.position, tarjeta2.transform.position);

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
