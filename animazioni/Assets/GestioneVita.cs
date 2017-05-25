using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestioneVita : MonoBehaviour 
{
	public GameObject cowboy;
	private int vita = 10;
	public Text testoVita;

	Image i; 

	// Use this for initialization
	void Start () 
	{
		i= GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void colpoSubito()
	{
		

		vita -= 2;
		if (vita <= 0) 
		{
			testoVita.text = "0";
			i.fillAmount = 0;
			cowboy.GetComponent<CowboyMove> ().muori ();
		} 
		else 
		{
			i.fillAmount -= 0.2f;
			testoVita.text = ""+vita;
		}




	}

	public void aumentoVita()
	{
		if (vita < 9) 
		{
			vita += 2;
			testoVita.text = "" + vita;
			i.fillAmount +=0.2f;
		}
		else 
		{
			vita = 10;
			testoVita.text = "10";
			i.fillAmount = 1;
		}
	}
}
