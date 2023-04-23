using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventOnTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent OnShadowTrigger;

    private bool isTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isTriggered)
        {
            Debug.Log("ShadowIn");
            OnShadowTrigger?.Invoke();
            isTriggered = true;
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && isTriggered)
        {
            isTriggered = false;
        }
    }
}
