using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    private Vector3 moveAmount;

    public float speed = 6;

    RandomSpawner rs;

   // int hitTarget = 0;

    private void Start()
    {
        rb = this.gameObject.AddComponent<Rigidbody>();
        rb.isKinematic = true;

        rs = GameObject.Find("RandomSpawner").GetComponent<RandomSpawner>();



    }

    private void OnTriggerEnter(Collider other)
    {

        //GameObject targetObject = GameObject.Find("target");


        if (other.tag == "target")
        {
            //hitTarget++;
            Debug.Log("hit target");
            //Destroy(targetObject);

         /*   if (hitTarget == 1)
            {
                rs.SpawnTarget();
            }*/

        }
        else
        {
            print("hit wall");
        }

    }

    /*private void OnTriggerExit(Collider other)
    {
        if (other.tag == "target")
        {
            hitTarget = 0;
        }
     }*/


        private void Update()
    {
        Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        moveAmount = moveInput.normalized * speed;


    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveAmount * Time.deltaTime);
    }
}
