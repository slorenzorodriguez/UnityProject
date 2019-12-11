using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController1 : MonoBehaviour {

    //Script Cámara principal; hacer que siga al player; desplazarse en su eje x con el movimiento del ratón;





	//jugador denomminado target
	private Transform target;
	//distancia entre camara y jugador
	public Vector3 offset;
	//[range] le digo que va a tener un rango de 0 a 1. Esta variable será modificable en Unity.
	[Range (0,1)]public float lerpValue;
	public float sensibility;

	// Use this for initialization
	void Start () {
		//hacemos que busque un objeto que tenga como etiqueta "player", y guardamos el transform (posiocion del player) dentro de la variable target/player
		target = GameObject.Find("Player").transform;
		
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		//vector3.lerp mueve la posicion de un objeto desde un vector a otro vector. 
		//Lerpvalue le dice a unity como de rapido tiene que pasar de una posicion a otra. 
		//Hago que la camara se mueva desde su posicion hasta la del target más o menos rápida.
		//A esto le sumo el offset; para darle una cierta distancia a la camara.
		 transform.position = Vector3.Lerp(transform.position, target.position + offset, lerpValue);




		//modificar el offset, para que la rotacion se incluya. Varía con el movimiento del ratón:
		//El offset varía según el mov. del raton. uso un quaternion para la rotacion, con un angleaxis para que rote con respecto a un eje.
		//Esta rotacion se la damos con el ratón; lo multiplicamos por una sensibilidad, y con el vector3.up hacemos que la rotacion sea sobre el eje que mira hacia arriba (z)
			offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * sensibility, Vector3.up) * offset;





		 //hacer que la camara vea automaticamente al player para no tener que modificarla manualmente.
		 transform.LookAt(target);
	}
}
