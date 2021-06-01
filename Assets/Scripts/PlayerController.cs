using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // El Range hace que se pueda crear un rango de velocidad entre 0 y 20 y el SerializeField hace que 
    // a pesar de que la variable sea privada, pueda aparecer en el editor y modificarla
    //Tooltip muestra un mensaje en el editor con el mensaje escrito
    [Range(0, 20), 
    SerializeField,
    Tooltip("Velocidad lineal máxima del coche")]
    private float spped = 10f;
    [Range(0, 90), 
     SerializeField,
     Tooltip("Velocidad de giro máxima del coche")]
    private float turnSpeed = 80f; // Velocidad de giro
    
    private float horizontalInput, verticalInput;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //Debug.Log("Movimiento horizontal : "+horizontalInput);
        //Movimiento
        transform.Translate(spped*Time.deltaTime*Vector3.forward * verticalInput);
        //Giro
        transform.Rotate(turnSpeed * Time.deltaTime * Vector3.up * horizontalInput);
    }
    
}
