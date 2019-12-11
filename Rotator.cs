using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {

        //Script rotacion picks ups.

        //transforma la posición del objeto en una rotación con su Vector3. Esto se multiplica por Time.deltaTime que hace que el movimiento sea más realistas.
		transform.Rotate(new Vector3(0,20,0) * Time.deltaTime);
		
	}
}
