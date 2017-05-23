using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeImage : MonoBehaviour 
{

	public Sprite acceso;
	public Sprite spento;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void changeTexture(bool accensione)
	{
		if (accensione) {
			Image im = GetComponent<Image> ();
			im.sprite = acceso;
		} else {
			Image im = GetComponent<Image> ();
			im.sprite = spento;
		}
	}
}
