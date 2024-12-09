using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material mat1;
    public Material mat2;
    public Material mat3;
    
    public Renderer rend1;
    public Renderer rend2;
    public Renderer rend3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeColor1()
    {
        rend1.material = mat1;
        rend2.material = mat1;
        rend3.material = mat1;
    }
    public void ChangeColor2()
    {
        rend1.material = mat2;
        rend2.material = mat2;
        rend3.material = mat2;
    }
    public void ChangeColor3()
    {
        rend1.material = mat3;
        rend2.material = mat3;
        rend3.material = mat3;
    }
}
