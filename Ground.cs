using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour {

	// Use this for initialization

   //Script para desaparición de objetos clave.

        //variables para los objetos
	public GameObject ground;
	public GameObject column;
	public GameObject button;

void OnTriggerEnter(Collider other) //en la colision con el trigger:

{
     //los 3 objetos se desactivan y desaparecen de la escena.
	ground.gameObject.SetActive(false);
	column.gameObject.SetActive (false);
	button.gameObject.SetActive (false);
	
	
	
	
}
}
