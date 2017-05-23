using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowboyMove : MonoBehaviour 
{
	Animator anim;
	//variabili per hash trigger
	private int pugno;
	private int avanti;
	private int indietro;
	private int morte;
	private int fermo;
	//variabili per i nomi dei trigger
	public string triggerPugno;
	public string triggerAvanti;
	public string triggerIndietro;
	public string triggerFermo;
	public string triggerMorte;
	//profilo giocatore 1o2
	public int profilo;
	//contatore morte
	private int vita=5;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();

		pugno = Animator.StringToHash (triggerPugno);
		avanti = Animator.StringToHash (triggerAvanti);
		indietro = Animator.StringToHash (triggerIndietro);
		fermo = Animator.StringToHash (triggerFermo);
		morte = Animator.StringToHash (triggerMorte);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (vita <= 0)
		{
			anim.SetTrigger (morte);
		}
		if (profilo == 1) 
		{
			if (Input.GetKeyDown (KeyCode.E)) 
			{
				anim.SetTrigger (pugno);
			}
			if (Input.GetKeyDown (KeyCode.W)) 
			{
				anim.SetTrigger (avanti);
			}
			if (Input.GetKeyDown (KeyCode.S)) 
			{
				anim.SetTrigger (indietro);
			}
			if (Input.GetKeyUp (KeyCode.W) || Input.GetKeyUp (KeyCode.S)) 
			{
				anim.SetTrigger (fermo);
			}

		} 
		else 
		{
			if (Input.GetKeyDown (KeyCode.R)) 
			{
				anim.SetTrigger (pugno);
			}
			if (Input.GetKeyDown (KeyCode.UpArrow)) 
			{
				anim.SetTrigger (avanti);
			}
			if (Input.GetKeyDown (KeyCode.DownArrow)) 
			{
				anim.SetTrigger (indietro);
			}
			if (Input.GetKeyUp (KeyCode.UpArrow) || Input.GetKeyUp (KeyCode.DownArrow)) 
			{
				anim.SetTrigger (fermo);
			}
			
		}

		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag.Equals ("ManoUno") && profilo == 2) 
		{
			vita--;
		}
		if (other.gameObject.tag.Equals ("ManoDue") && profilo == 1) 
		{
			vita--;
		}

	}
}
