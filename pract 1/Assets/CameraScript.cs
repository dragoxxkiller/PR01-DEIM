using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Tranform con t mayus es variable , con t minus es componente

    private Quaternion cameraPosition = new Quaternion(0f, 0f, 0f, 0f);
    [SerializeField] Transform player;
    [SerializeField] GameObject playerObject;

    // Start is called before the first frame update
    void Start()
    {


        transform.rotation = cameraPosition;



    }

    // Update is called once per frame
    void Update()
    {
       /* transform.LookAt(player);
       transform.position = new Vector3(playerObject.transform.position.x, playerObject.transform.position.y, transform.position.z);
        
        
      
        print(playerObject.transform.position);
       */
    }
}
