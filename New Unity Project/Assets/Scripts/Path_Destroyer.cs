using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path_Destroyer : MonoBehaviour
{
    public float movespeed = 10f;

    private bool isWalking = false;
    private bool isWandering = false;

    public GameObject Player;
    public float target_Distance;
    public float Allowed_Distance = 20f;
    public GameObject Enemy;
    public float Follow_Speed;
    public RaycastHit Shot;


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

        transform.LookAt(Player.transform);
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward),out Shot))
        {
            target_Distance = Shot.distance;
            if(target_Distance <= Allowed_Distance )
            {
                Follow_Speed = 4f;
                transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, Follow_Speed);
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, target_Distance);
    }

    IEnumerator Wandering()
    {
        int walk_Wait = Random.Range(1, 10);
        int walk_Time = Random.Range(1, 4);

        isWandering = true;

        yield return new WaitForSeconds(walk_Wait);
        isWalking = true;
        yield return new WaitForSeconds(walk_Time);
        isWalking = false;
        isWandering = false;
    }
}
