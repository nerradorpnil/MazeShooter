using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public Transform player;
    public float moveSpeed = 6f;
    public float detectionRadius = 25f;
    public float damageAmount = 25f;

    private Vector3 initialPosition;

    void Start() {
        initialPosition = transform.position;
    }

    void Update() {
        // Check if the player is within the detection radius
        if (Vector3.Distance(transform.position, player.position) <= detectionRadius) {
            // Make the enemy face towards the player
            transform.LookAt(player);

            // Move the enemy towards the player
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Player")) {
            // Destroy the enemy object
            Destroy(gameObject);
            
            // Take damage to the player
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(damageAmount);
        }

    }
}
