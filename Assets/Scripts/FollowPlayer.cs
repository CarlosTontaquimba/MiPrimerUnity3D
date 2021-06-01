using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
   //ESTE SCRIPT ES PARA QUE LA CÁMARA SIGA EL JUGADOR
   public GameObject player;
   //Tecnica de offset 
   public  Vector3 offset = new Vector3(0, 5, -6);
   private void Update()
   {
      //this.transform.position = posicion actual del transform de la camara
      this.transform.position = player.transform.position +  offset; // Copiamos el valor de la posicion del transform del player a la posicion del transform de la camara
   }
}
