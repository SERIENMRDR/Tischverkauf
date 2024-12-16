using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeModell : MonoBehaviour
{
    public TMP_Dropdown dropdown;

    public int model = 0;

    public void ChangeModel()
    {
        switch (dropdown.value)
        {
            case 0:
                model = 0;
                break;
            case 1:
                model = 1;
                break;
        }

    }
}