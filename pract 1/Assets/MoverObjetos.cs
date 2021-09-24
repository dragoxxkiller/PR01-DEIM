using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverObjetos : MonoBehaviour
{

    private Vector3 cubePosition = new Vector3 (0, 0, 0);


    public float speed = 50f;




    // Start is called before the first frame update
    void Start()
    {


        transform.position = new Vector3(0f, 0f, 0f);

        



    }

    // Update is called once per frame
    void Update()
    {
        float desp1H = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * Time.deltaTime * speed * desp1H);

        float desp1V = Input.GetAxis("Vertical");

        transform.Translate(Vector3.up * Time.deltaTime * speed * desp1V);

        float desp1F = Input.GetAxis("Profundidad");

        transform.Translate(Vector3.back * Time.deltaTime * speed * desp1F);

        /* Vector3 destPos = new Vector3(-1f, 0f, 0f);

        cubePosition = cubePosition + destPos * Time.deltaTime * speed;

         transform.position = cubePosition;

         print(transform.position.x);
        */






    }
}
