using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboPract1 : MonoBehaviour
{

    public string mensaje = "Houston tenemos un problema";
    public string mensaje2 = "Te me bajas tres tonitos";
    public string nombrecito = "Eustaquio";
    public int numerito = 20;
    public float numero = 1.23f;
    public bool Alive = true;
     int n = 2;
    int m = 10;
    int k = 14;
    string Saludo;
    

        int multiplicar (int n , int m)
        {

            int resultado = n * m;
            return resultado;
            
        }

    void Saludito (string hola)
    {
        print("holiwi" + hola);
    }



    // Start is called before the first frame update
    void Start()
    {

       int resultado = multiplicar(2, 20);
        print(resultado);

        if (resultado != 20)
        {
            bool Alive = false;
            print(Alive);

        }


        Saludito("Eustaquio");









      
    }

    // Update is called once per frame
    void Update()
    {
       

        
        


    }
}
