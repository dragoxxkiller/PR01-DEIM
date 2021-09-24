using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CuboPract1 : MonoBehaviour
{

    public string mensaje = "Houston tenemos un problema";
    public string mensaje2 = "Te me bajas tres tonitos";
    public string nombrecito = "Eustaquio";
    public int numerito = 20;
    public float numero = 1.23f;
    public bool Alive = true;
    int n = 0;
    int m = 0;
    int k = 0;
    string Saludo;
    public Text timer;

        int multiplicar (int n , int m)
        {

            int resultado = n * m;
            return resultado;
            
        }

    void Saludito (string hola)
    {
        print("holiwi" + hola);
    }

    IEnumerator contador()
    {
        while (true)
        {
            print("la hora es" + n + ":" + m + ":" + k);

            timer.text = "la hora es" + n + ":" + m + ":" + k;
            k++;
            yield return new WaitForSeconds(1f);

            if (k == 60)
            {
                k = 0;
                m++;

            }

            if (m == 60)
            {
                n++;
            }
        }
    }



    // Start is called before the first frame update
    void Start()
    {


        StartCoroutine("contador");

        







      
    }

    // Update is called once per frame
    void Update()
    {
       

        
        


    }
}
