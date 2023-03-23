using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject prefab;
    public GameObject shootPoint; 
    public GameObject enemy;
    public float pushForce = 20f;
     
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject clone = Instantiate(prefab);
            
            clone.transform.position = shootPoint.transform.position;
            clone.transform.rotation = shootPoint.transform.rotation; 

        }
        
    }
    void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
             // Destroy the enemy and the bullet
                Destroy(collision.gameObject);
                Destroy(collision.collider.gameObject);

                Destroy(enemy);
            }
        }

}
