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



    // Start is called before the first frame update
    void Start()
    {


        print(mensaje + mensaje2);
        print(mensaje);
        print(Alive);
        print(numero);
        print(numerito);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
