using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
   private void OnCollisionEnter(Collision other)
   {
      if(other.gameObject.tag == "Player")
      {
         GetComponent<MeshRenderer>().material.color = Color.cyan;
         gameObject.tag = "Hit";
      } 
   }
}
