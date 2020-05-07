using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{

	public float MaxSpeed;
	public float TimeDestroy;
	private Rigidbody2D TheBody;
	private Vector2 screenBounds;
    // Start is called before the first frame update
    protected void Start()
    {


       	MaxSpeed =-10.0f;
        TimeDestroy=2.0f;
        TheBody = GetComponent<Rigidbody2D> ();
     //   Invoke("Destroy",TimeDestroy);
    }

    
    void FixedUpdate(){

    	TheBody.velocity = new Vector4 (MaxSpeed,0,0);
    }

    void Destroy(){
	
	//	Destroy(gameObject)	;
  	}
 	
}
