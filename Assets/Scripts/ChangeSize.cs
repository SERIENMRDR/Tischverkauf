using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSize : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public GameObject tisch1;
    public GameObject tisch2;
    public GameObject tisch3;
    public GameObject mtisch1;
    public GameObject mtisch2;
    public GameObject mtisch3;
    public ChangeModell m;

    public void Update()
    {
        ChangeSize1();
    }

    public void ChangeSize1()
    {

        switch (dropdown.value)
        {
            case 0:
                if (m.model == 0)
                {
                    tisch1.SetActive(true);
                    tisch2.SetActive(false);
                    tisch3.SetActive(false);
                    mtisch1.SetActive(false);
                    mtisch2.SetActive(false);
                    mtisch3.SetActive(false);
                }
                else if (m.model == 1)
                {
                    tisch1.SetActive(false);
                    tisch2.SetActive(false);
                    tisch3.SetActive(false);
                    mtisch1.SetActive(true);
                    mtisch2.SetActive(false);
                    mtisch3.SetActive(false);
                }
                
                break;
            case 1:
                if (m.model == 0)
                {
                    tisch1.SetActive(false);
                    tisch2.SetActive(true);
                    tisch3.SetActive(false);
                    mtisch1.SetActive(false);
                    mtisch2.SetActive(false);
                    mtisch3.SetActive(false);
                }
                else if (m.model == 1)
                {
                    tisch1.SetActive(false);
                    tisch2.SetActive(false);
                    tisch3.SetActive(false);
                    mtisch1.SetActive(false);
                    mtisch2.SetActive(true);
                    mtisch3.SetActive(false);
                }
                break;
            case 2:
                if (m.model == 0)
                {
                    tisch1.SetActive(false);
                    tisch2.SetActive(false);
                    tisch3.SetActive(true);
                    mtisch1.SetActive(false);
                    mtisch2.SetActive(false);
                    mtisch3.SetActive(false);
                }
                else if (m.model == 1)
                {
                    tisch1.SetActive(false);
                    tisch2.SetActive(false);
                    tisch3.SetActive(false);
                    mtisch1.SetActive(false);
                    mtisch2.SetActive(false);
                    mtisch3.SetActive(true);
                }
                break;
        }
    }
}      

