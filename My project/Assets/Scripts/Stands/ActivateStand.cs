using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateStand : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent.TryGetComponent<Stand>(out Stand stand)) 
        {
            stand.__ShowProjects();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.parent.TryGetComponent<Stand>(out Stand stand))
        {
            stand.__HideProjects();
        }
    }
}
