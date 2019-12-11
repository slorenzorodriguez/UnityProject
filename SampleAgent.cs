using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SampleAgent : MonoBehaviour

    //Script general del enemigo.
{
    //nuestro player
    public Transform target;
    //el agente/enemigo
    NavMeshAgent agent;
    public float speed;
    // distancia minima para cambiar la animacion
    public float proximity;
    // el animator
    Animator animator;
    public float maxAngle;
    public float maxRadius;

    //public bool isInFov = false;




    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        animator = target.GetComponent<Animator>();



    }


    void Update()
    {

        //le doy al agent como destino la posición del target/player; esto hace que el agent siempre persiga al player
        agent.SetDestination(target.position);


        // comparamos la distancia al enemigo
        // cambiamos la variable bool
        // de esta manera forzamos la transicion desde Tarnquilo a Peligro
        // y viceversa
        if (!agent.pathPending && agent.remainingDistance < proximity)
        {
            //debug.log hará que salga un mensaje en la consola del programa
            Debug.Log("Danger");
            // cambiamos a true la variable del animator
            animator.SetBool("EstarEnPeligro", true);
        }
        else
        {
            //debug.log hará que salga un mensaje en la consola del programa
            Debug.Log("Tranquility");
            // cambiamos a false la variable del animator
            animator.SetBool("EstarEnPeligro", false);




        }
    }

}
