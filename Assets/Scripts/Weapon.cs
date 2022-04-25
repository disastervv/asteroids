using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{


   public Transform firePoint;
   public GameObject LuotiPrefab;

    // Update is called once per frame
    void Update() {
if (Input.GetButtonDown("Fire1"))
    {
        Shoot();
    }
}

void Shoot ()
{
   GameObject newluoti = Instantiate(LuotiPrefab, firePoint.position, firePoint.rotation); 
Rigidbody2D rb = newluoti.GetComponent< Rigidbody2D > ();
rb.AddForce (transform.up * 10f ) ;
Destroy (newluoti, 10 );
}



}