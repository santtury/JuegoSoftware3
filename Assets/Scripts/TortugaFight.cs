using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TortugaFight : MonoBehaviour
{
    
    public float speed=5f;

    public float padding = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    //  if(Input.GetKey(KeyCode.LeftArrow)){
        //moviendo a la izquierda
    //  this.transform.position += new Vector3 (-speed*Time.deltaTime, 0, 0);

    //  } else if (Input.GetKey(KeyCode.RightArrow)){
        //moviendo a la derecha
    //  this.transform.position += new Vector3 (speed*Time.deltaTime, 0, 0);

    //  }
        //Movimiento Horizontal
        float hInput = Input.GetAxis("Horizontal");
        transform.position += new Vector3(hInput* speed*Time.deltaTime,0,0);

        //Movimiento Vertical
        float vInput = Input.GetAxis("Vertical");
        transform.position += new Vector3(0,vInput* speed*Time.deltaTime,0);

    //Clamping, Rectificacion
    float newX = Mathf.Clamp(transform.position.x,-16 + padding,16 - padding ); 
    float newY = Mathf.Clamp(transform.position.y,-10+padding,10 - padding);    
    transform.position= new Vector3(newX,newY, transform.position.z);

    }
}

