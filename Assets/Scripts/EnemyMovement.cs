using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float followRange = 5f;

    private Transform playerTransform;

    private void Start()
    {
        // Find the player's transform using their tag
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        // Calculate the distance between the enemy and the player
        float distanceToPlayer = Vector2.Distance(transform.position, playerTransform.position);

        // Check if the player is within the follow range
        if (distanceToPlayer < followRange)
        {
            // Calculate the direction to the player
            Vector2 directionToPlayer = (playerTransform.position - transform.position).normalized;

            // Move the enemy towards the player
            transform.Translate(directionToPlayer * moveSpeed * Time.deltaTime);
        }
    }

}
