﻿using UnityEngine;
using System.Collections;

public class DummyScript : MonoBehaviour {

    public Collider collider_dummy;
    public Animator anim;

	 public float velocidadMax;
     
     public float xMax;
     public float zMax;
     public float xMin;
     public float zMin;

     public float vida;
         
     private float x;
     private float z;
     private float tiempo;
     private float angulo;
 
     // Use this for initialization
     void Start () {
        collider_dummy = GetComponent<Collider> ();
        anim = GetComponent<Animator> ();
        x = Random.Range(-velocidadMax, velocidadMax);
        z = Random.Range(-velocidadMax, velocidadMax);
        angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) ;
        transform.localRotation = Quaternion.Euler( 0, angulo, 0);
     }
     
     // Update is called once per frame
    void OnTriggerEnter(Collider collider_dummy) {
        //LayerMask.GetMask("HitBox")
        if(collider_dummy.name == "El Lechero") {
            if(vida > 1){
                vida = vida - 1;
                anim.Play ("Hit", -1, 0f);
            }
            else if(vida == 1) {
                vida = vida - 1;
                velocidadMax=0;
                anim.Play ("dead", -1, 0f);   
            }
        }
    }
     void Update () {
 
         tiempo += Time.deltaTime;
 
         if (transform.localPosition.x > xMax) {
             x = Random.Range(-velocidadMax, 0.0f);
             angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) ;
             transform.localRotation = Quaternion.Euler(0, angulo, 0);
             tiempo = 0.0f; 
         }
         if (transform.localPosition.x < xMin) {
             x = Random.Range(0.0f, velocidadMax);
             angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) ;
             transform.localRotation = Quaternion.Euler(0, angulo, 0); 
             tiempo = 0.0f; 
         }
         if (transform.localPosition.z > zMax) {
             z = Random.Range(-velocidadMax, 0.0f);
             angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) ;
             transform.localRotation = Quaternion.Euler(0, angulo, 0); 
             tiempo = 0.0f; 
         }
         if (transform.localPosition.z < zMin) {
             z = Random.Range(0.0f, velocidadMax);
             angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) ;
             transform.localRotation = Quaternion.Euler(0, angulo, 0);
             tiempo = 0.0f; 
         }
 
 
         if (tiempo > 1.0f) {
             x = Random.Range(-velocidadMax, velocidadMax);
             z = Random.Range(-velocidadMax, velocidadMax);
             angulo = Mathf.Atan2(x, z) * (180 / 3.141592f) ;
             transform.localRotation = Quaternion.Euler(0, angulo, 0);
             tiempo = 0.0f;
         }
 
         transform.localPosition = new Vector3(transform.localPosition.x + x, transform.localPosition.y, transform.localPosition.z + z);
     }
}
