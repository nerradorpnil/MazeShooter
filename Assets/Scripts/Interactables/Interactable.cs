using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    //add/remove InteractionEvent to gameobject
    public bool useEvents;
    [SerializeField]
    public string promptMessage;

    public void BaseInteract()  //called from player
    {
        if(useEvents)
        {
            GetComponent<InteractionEvent>().OnInteract.Invoke();
        }
        Interact();
    }
    protected virtual void Interact()
    {

    }
}
