using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Heladeria : MonoBehaviour
{
    public string gusto;
    public int cantidad;

    float precio;

    // Start is called before the first frame update
    void Start()
    {
        if (gusto != "CHO" && gusto != "FRU" && gusto != "DDL" || cantidad < 250 || cantidad > 3000)
        {
            Debug.Log("Los datos ingresados no son validos");
            return;
        }
        precio = cantidad * 0.5f;
        if (gusto == "FRU")
        {
            precio -= (precio * 10) / 100;
        }
        Debug.Log("El costo del pedido es: " + precio);
        

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
