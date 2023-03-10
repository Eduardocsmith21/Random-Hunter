using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriarBalas : MonoBehaviour
{
    public GameObject balas;
    public GameObject cano;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate (balas, new Vector3(cano.transform.position.x,cano.transform.position.y,cano.transform.position.z), cano.transform.rotation);
        }
        
    }
}
