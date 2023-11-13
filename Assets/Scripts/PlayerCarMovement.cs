using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCarMovement : MonoBehaviour
{

    public float moveSpeed = 40f;


    [SerializeField]
    private float turnSpeed = 70f;

    private float movementX;
    private float movementY;

    [SerializeField]
    public Rigidbody rb;
    public AudioSource Caraudio;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movementX = Input.GetAxis("Horizontal");
        movementY = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime * movementY);
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * movementX);

          if(movementY>0)
        {
            Caraudio.Play();
        }

        else if(movementY==0 || movementY<0)
        {
            Caraudio.Stop();
        }

        if(rb.position.y<-6f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }



    public void repositionPlayer()
    {
      
        transform.position=new Vector3(51.36f,0.1411227f,transform.position.z);
        transform.rotation = Quaternion.identity;
    }

   


}