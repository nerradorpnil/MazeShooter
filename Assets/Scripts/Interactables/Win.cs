using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportInteractable : Interactable
{
    [SerializeField]
    private Transform teleportTarget; // the position to teleport the player to

    protected override void Interact()
    {
        // teleport the player to the target position
        GameObject player = GameObject.FindWithTag("Player"); // find the player object by tag
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
