using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowboyMove : MonoBehaviour 
{
	//i due cowboy
	public GameObject altroCowboy;
	Animator anim;
	Animator altroAnim;
	//variabili per hash trigger
	private int pugno;
	private int avanti;
	private int indietro;
	private int morte;
	//variabili per i nomi dei trigger
	public string triggerPugno;
	public string triggerAvanti;
	public string triggerIndietro;
	public string triggerMorte;
	//profilo giocatore 1o2
	public int profilo;
	public GameObject gestoreVita1;
	public GameObject gestoreVita2;
	//timer vita
	private float timerVita; 

	// Use this for initialization
	void Start () 
	{
		timerVita = 0f;

		anim = GetComponent<Animator> ();
		altroAnim = altroCowboy.GetComponent<Animator> ();

		pugno = Animator.StringToHash (triggerPugno);
		avanti = Animator.StringToHash (triggerAvanti);
		indietro = Animator.StringToHash (triggerIndietro);
		morte = Animator.StringToHash (triggerMorte);
	}
	
	// Update is called once per frame
	void Update () 
	{
		timerVita += Time.deltaTime;

		if (timerVita >= 5f) 
		{
			if (profilo == 1) 
			{
				timerVita = 0f;
				gestoreVita1.GetComponent<GestioneVita> ().aumentoVita ();
			}
			if (profilo == 2)
			{
				timerVita = 0f;
				gestoreVita2.GetComponent<GestioneVita> ().aumentoVita ();
			}
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

			
		}

		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag.Equals ("ManoUno") && profilo == 2 && altroAnim.GetCurrentAnimatorStateInfo(0).IsName("Punch") ) 
		{
			gestoreVita2.GetComponent<GestioneVita> ().colpoSubito();
			timerVita = 0f;
		}
		if (other.gameObject.tag.Equals ("ManoDue") && profilo == 1 && altroAnim.GetCurrentAnimatorStateInfo(0).IsName("Punch")) 
		{
			gestoreVita1.GetComponent<GestioneVita> ().colpoSubito();
			timerVita = 0f;
		}

	}

	public void muori()
	{
		anim.SetTrigger (morte);
	}

}
