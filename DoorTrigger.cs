using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    //Script para cerrar la puerta principal.

    public GameObject Door;


    void OnTriggerEnter(Collider other) { //en la colision con el trigger:

        //El objeto 'Door' modificará su posición en su Vector3; esto hará que la puerta se cierre.
        Door.transform.position += new Vector3(0, -4, 0);

}
}

	
	

