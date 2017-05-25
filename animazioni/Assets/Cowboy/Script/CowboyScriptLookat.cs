using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowboyScriptLookat : MonoBehaviour {

	public GameObject altroCowboy;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.LookAt (altroCowboy.transform);
		
	}
}
