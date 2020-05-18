using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transpot_Ship_Path : MonoBehaviour
{
    public float movespeed = 10f;

    private bool isWalking = false;
    private bool isWandering = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isWandering == false)
        {
            StartCoroutine(Wandering());
        }

        if (isWalking == true)
        {
            transform.position += transform.forward * movespeed * Time.deltaTime;
        }
    }

    IEnumerator Wandering()
    {
        int walk_Wait = Random.Range(1, 3);
        int walk_Time = Random.Range(5, 15);

        isWandering = true;

        yield return new WaitForSeconds(walk_Wait);
        isWalking = true;
        yield return new WaitForSeconds(walk_Time);
        isWalking = false;
        isWandering = false;
    }
}
