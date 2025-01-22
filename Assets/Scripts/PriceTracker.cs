using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class PriceTracker : MonoBehaviour
{
    public TMP_Dropdown SizeDropdown;
    public TMP_Dropdown ModelDropdown;
    public TMP_Text PriceText;
    // Start is called before the first frame update
    public float BasePrice;
    private float Price;

    public void Start()
    {
        Price = BasePrice+ 50*SizeDropdown.value + 200*ModelDropdown.value;
    }


    public void ChangePrice()
    {
        Price = BasePrice+ 50*SizeDropdown.value + 200*ModelDropdown.value;
    }
    
    // Update is called once per frame
    void Update()
    {
        PriceText.text = "Preis: " + Price + "€";
    }
}
