using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLight : MonoBehaviour 
{
	private bool accensione;
	public GameObject pulsante;

	// Use this for initialization
	void Start () 
	{
		this.accensione = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void turnLight()
	{
		if (accensione) 
		{
			GetComponent<Light> ().enabled = false;
			pulsante.GetComponent<changeImage> ().changeTexture (false);
			accensione = false;
		} else 
		{
			GetComponent<Light> ().enabled = true;
			pulsante.GetComponent<changeImage> ().changeTexture (true);
			accensione = true;
		}
	}
}
