using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private bool hidrogeno;
    private bool carbono;
    private bool nitrogeno;
    private bool oxigeno;
    private bool sodio;
    private bool cloro;
    public GameObject tarjH;
    public GameObject tarjC;
    public GameObject tarjN;
    public GameObject tarjO;
    public GameObject tarjNa;
    public GameObject tarjCl;

    // Start is called before the first frame update
    void Start()
    {
        hidrogeno = false;
        carbono = false;
        nitrogeno = false;
        oxigeno = false;
        sodio = false;
        cloro = false;
        tarjH.transform.GetChild(0).gameObject.SetActive(false);
        tarjH.transform.GetChild(1).gameObject.SetActive(false);
        tarjC.transform.GetChild(0).gameObject.SetActive(false);
        tarjC.transform.GetChild(1).gameObject.SetActive(false);
        tarjN.transform.GetChild(0).gameObject.SetActive(false);
        tarjN.transform.GetChild(1).gameObject.SetActive(false);
        tarjO.transform.GetChild(0).gameObject.SetActive(false);
        tarjO.transform.GetChild(1).gameObject.SetActive(false);
        tarjNa.transform.GetChild(0).gameObject.SetActive(false);
        tarjNa.transform.GetChild(1).gameObject.SetActive(false);
        tarjCl.transform.GetChild(0).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float distH2O = Vector3.Distance(tarjH.transform.position, tarjO.transform.position);
        float distCH4 = Vector3.Distance(tarjC.transform.position, tarjH.transform.position);
        float distNH3 = Vector3.Distance(tarjN.transform.position, tarjH.transform.position);
        float distCO2 = Vector3.Distance(tarjC.transform.position, tarjO.transform.position);
        float distNaCl = Vector3.Distance(tarjNa.transform.position, tarjCl.transform.position);
        
        if (hidrogeno)
        {    
            if (oxigeno)
            {
                if (distH2O < 13 && !tarjH.transform.GetChild(1).gameObject.activeInHierarchy)
                {
                    tarjH.transform.GetChild(0).gameObject.SetActive(false); //Desactiva atomo H
                    tarjO.transform.GetChild(0).gameObject.SetActive(false); //Desactiva atomo O
                    tarjH.transform.GetChild(1).gameObject.SetActive(true); //Activa molecula H2O
                }
                else if (distH2O > 13 && tarjH.transform.GetChild(1).gameObject.activeInHierarchy)
                {
                    tarjH.transform.GetChild(1).gameObject.SetActive(false); //Desactiva molecula H2O
                    if (!tarjO.transform.GetChild(1).gameObject.activeInHierarchy)
                    {
                        tarjO.transform.GetChild(0).gameObject.SetActive(true); //Activa atomo O
                    }
                    if (!tarjC.transform.GetChild(1).gameObject.activeInHierarchy && !tarjN.transform.GetChild(1).gameObject.activeInHierarchy)
                    {
                        tarjH.transform.GetChild(0).gameObject.SetActive(true); //Activa atomo H
                    }
                }
            }
            if (carbono)
            {
                if (distCH4 < 13 && !tarjC.transform.GetChild(1).gameObject.activeInHierarchy)
                {
                    tarjH.transform.GetChild(0).gameObject.SetActive(false); //Desactiva atomo H
                    tarjC.transform.GetChild(0).gameObject.SetActive(false); //Desactiva atomo C
                    tarjC.transform.GetChild(1).gameObject.SetActive(true); //Activa molecula CH4
                }
                else if (distCH4 > 13 && tarjC.transform.GetChild(1).gameObject.activeInHierarchy)
                {
                    tarjC.transform.GetChild(1).gameObject.SetActive(false); //Desactiva molecula CH4
                    if (!tarjO.transform.GetChild(1).gameObject.activeInHierarchy)
                    {
                        tarjC.transform.GetChild(0).gameObject.SetActive(true); //Activa atomo C
                    }
                    if (!tarjH.transform.GetChild(1).gameObject.activeInHierarchy && !tarjN.transform.GetChild(1).gameObject.activeInHierarchy)
                    {
                        tarjH.transform.GetChild(0).gameObject.SetActive(true); //Activa atomo H
                    }
                }
            }
            if (nitrogeno)
            {
                if (distNH3 < 13 && !tarjN.transform.GetChild(1).gameObject.activeInHierarchy)
                {
                    tarjH.transform.GetChild(0).gameObject.SetActive(false); //Desactiva atomo H
                    tarjN.transform.GetChild(0).gameObject.SetActive(false); //Desactiva atomo N
                    tarjN.transform.GetChild(1).gameObject.SetActive(true); //Activa molecula NH3
                }
                else if (distNH3 > 13 && tarjN.transform.GetChild(1).gameObject.activeInHierarchy)
                {
                    tarjN.transform.GetChild(1).gameObject.SetActive(false); //Desactiva molecula NH3
                    tarjN.transform.GetChild(0).gameObject.SetActive(true); //Activa atomo N
                    if (!tarjH.transform.GetChild(1).gameObject.activeInHierarchy && !tarjC.transform.GetChild(1).gameObject.activeInHierarchy)
                    {
                        tarjH.transform.GetChild(0).gameObject.SetActive(true); //Activa atomo H
                    }
                }
            }
        }
        if (carbono)
        {
            if (oxigeno)
            {
                if (distCO2 < 13 && !tarjO.transform.GetChild(1).gameObject.activeInHierarchy)
                {
                    tarjO.transform.GetChild(0).gameObject.SetActive(false); //Desactiva atomo O
                    tarjC.transform.GetChild(0).gameObject.SetActive(false); //Desactiva atomo C
                    tarjO.transform.GetChild(1).gameObject.SetActive(true); //Activa molecula CO2
                }
                else if (distCO2 > 13 && tarjO.transform.GetChild(1).gameObject.activeInHierarchy)
                {
                    tarjO.transform.GetChild(1).gameObject.SetActive(false); //Desactiva molecula CO2
                    if (!tarjC.transform.GetChild(1).gameObject.activeInHierarchy)
                    {
                        tarjC.transform.GetChild(0).gameObject.SetActive(true); //Activa atomo C
                    }
                    if (!tarjH.transform.GetChild(1).gameObject.activeInHierarchy)
                    {
                        tarjO.transform.GetChild(0).gameObject.SetActive(true); //Activa atomo O
                    }
                }
            }
        }

        if (sodio)
        {
            if (cloro)
            {
                if (distNaCl < 13 && !tarjNa.transform.GetChild(1).gameObject.activeInHierarchy)
                {
                    tarjCl.transform.GetChild(0).gameObject.SetActive(false); //Desactiva atomo Cl
                    tarjNa.transform.GetChild(0).gameObject.SetActive(false); //Desactiva atomo Na
                    tarjNa.transform.GetChild(1).gameObject.SetActive(true); //Activa molecula NaCl
                }
                else if (distNaCl > 13 && tarjNa.transform.GetChild(1).gameObject.activeInHierarchy)
                {
                    tarjNa.transform.GetChild(1).gameObject.SetActive(false); //Desactiva molecula NaCl
                    tarjNa.transform.GetChild(0).gameObject.SetActive(true); //Activa atomo Na
                    tarjCl.transform.GetChild(0).gameObject.SetActive(true); //Activa atomo Cl
                }
            }
        }

    }

    public void activar(int elemento)
    {
        switch (elemento)
        {
            case 1:
                hidrogeno = true;
                tarjH.transform.GetChild(0).gameObject.SetActive(true);
                break;
            case 2:
                carbono = true;
                tarjC.transform.GetChild(0).gameObject.SetActive(true);
                break;
            case 3:
                nitrogeno = true;
                tarjN.transform.GetChild(0).gameObject.SetActive(true);
                break;
            case 4:
                oxigeno = true;
                tarjO.transform.GetChild(0).gameObject.SetActive(true);
                break;
            case 5:
                sodio = true;
                tarjNa.transform.GetChild(0).gameObject.SetActive(true);
                break;
            case 6:
                cloro = true;
                tarjCl.transform.GetChild(0).gameObject.SetActive(true);
                break;
        }
    }

    public void desactivar(int elemento)
    {
        switch (elemento)
        {
            case 1:
                hidrogeno = false;
                tarjH.transform.GetChild(0).gameObject.SetActive(false);
                tarjH.transform.GetChild(1).gameObject.SetActive(false);
                break;
            case 2:
                carbono = false;
                tarjC.transform.GetChild(0).gameObject.SetActive(false);
                tarjC.transform.GetChild(1).gameObject.SetActive(false);
                break;
            case 3:
                nitrogeno = false;
                tarjN.transform.GetChild(0).gameObject.SetActive(false);
                tarjN.transform.GetChild(1).gameObject.SetActive(false);
                break;
            case 4:
                oxigeno = false;
                tarjO.transform.GetChild(0).gameObject.SetActive(false);
                tarjO.transform.GetChild(1).gameObject.SetActive(false);
                break;
            case 5:
                sodio = false;
                tarjNa.transform.GetChild(0).gameObject.SetActive(false);
                tarjNa.transform.GetChild(1).gameObject.SetActive(false);
                break;
            case 6:
                cloro = false;
                tarjCl.transform.GetChild(0).gameObject.SetActive(false);
                break;
        }
    }


}
