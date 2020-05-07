using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScripCn : MonoBehaviour
{


	public Slider slider;
	public Text txt;

	public float energy=10;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    	slider.value=energy;
    	txt.text=energy.ToString();
        
    }
}
