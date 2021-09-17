using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboPract1 : MonoBehaviour
{

    public string mensaje = "Houston tenemos un problema";
    public string mensaje2 = "Te me bajas tres tonitos";
    public int numerito = 20;
    public float numero = 1.23f;
    public bool Alive = true;
     int n = 0;
    int m = 10;
    int k = 14;

    // Start is called before the first frame update
    void Start()
    {

       while (m < 20)
        {
            m++;
            print(m);
            if(m == 20)
            {
                print(mensaje);
            }

        }
        for (k = 14; k <= 69; k++) 
        {
            print(k);
            if (k == 69)
            {
                print(mensaje2);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
       

        
        


    }
}
