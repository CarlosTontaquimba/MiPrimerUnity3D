using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    //private Vector3 offset = new Vector3(0,6,-10);
    private Vector3 playerPreviousPos = Vector3.zero;

    private float distance = 20f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 offset = posicion actual - posicion anterior esta resta nos da el vector de desplazamiento
        Vector3 offset = plane.transform.position - playerPreviousPos;
        if (offset.magnitude < 0.5f){return;} // SI el avion de la posicion anterior a la actual se ha movido menos medio metro, no se mueve 
        {
            
        }
        offset.Normalize(); // Se normaliza el vector para transformar un vector en uno que tenga un tamaño 1
        transform.position = plane.transform.position - offset * distance; // Quiero mi camara (distance) metros por detras de mi avion
        //Hacemos que la camara mire a la avioneta 
        transform.LookAt(plane.transform.position);
        playerPreviousPos = plane.transform.position;
    }
}
