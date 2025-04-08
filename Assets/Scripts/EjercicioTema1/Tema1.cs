using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tema1 : MonoBehaviour
{
    //1. Declaración de variables 
    public float montoAConvertir;
    public string codigoMoneda;

    float montoConvertido;

    float cotizacionMonedaElegida;
    // Start is called before the first frame update
    void Start()
    {

        //2. Ingreso y validación de datos
        if (montoAConvertir < 1000)
        {
            Debug.Log("El monto minimo es $1000");
            return;
        }
        if (codigoMoneda == "D")
        {
            cotizacionMonedaElegida = 1134.5f;
        }
        else if (codigoMoneda == "E")
        {
            cotizacionMonedaElegida = 1397.36f;
        }
        else if (codigoMoneda == "R")
        {
            cotizacionMonedaElegida = 211;
        }
        else
        {
            Debug.Log("Opcion de moneda extranjera no valida");
            return;
        }
         
      


        //3. Operaciones y procesamiento de datos

        montoConvertido = montoAConvertir / cotizacionMonedaElegida;

        //4. Salida de datos
        Debug.Log("Monto convertido: " + montoConvertido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
