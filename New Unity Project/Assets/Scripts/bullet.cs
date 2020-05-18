using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject lazer;
    public float L_Speed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject instLazer = Instantiate(lazer, transform.position, Quaternion.identity) as GameObject;
            Rigidbody instLazerRigidbody = instLazer.GetComponent<Rigidbody>();
            instLazerRigidbody.AddForce(Vector3.forward * L_Speed);
        }
    }
}
