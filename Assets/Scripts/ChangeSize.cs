using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSize : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public GameObject tisch1;
    public GameObject tisch2;
    public GameObject tisch3;
    
    public void ChangeSize1()
    {
        switch (dropdown.value)
        {
            case 0:
                tisch1.SetActive(true);
                tisch2.SetActive(false);
                tisch3.SetActive(false);
                break;
            case 1:
                tisch1.SetActive(false);
                tisch2.SetActive(true);
                tisch3.SetActive(false);
                break;
            case 2:
                tisch1.SetActive(false);
                tisch2.SetActive(false);
                tisch3.SetActive(true);
                break;
        }

    }
    
}
