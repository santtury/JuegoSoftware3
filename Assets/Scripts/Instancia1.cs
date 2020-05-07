using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancia1 : MonoBehaviour
{

	public GameObject Botella;
	private int Number=20;
    // Start is called before the first frame update
    void Start()
    {
	//	InvokeRepeating("FixedUpdate",0f,1.75f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){

    	if(Number==Random.Range (1,50)){

    		Instantiate (Botella, new Vector3 (transform.position.x,Random.Range (-10,10),0),Quaternion.identity);
    	}

    }
    


}
