using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform target; // El objeto al que "L" seguir�

    private void Update()
    {
        if (target != null)
        {
            // Actualizar la posici�n de "L" para que siga la posici�n de "M"
            transform.position = target.position;
        }
    }
}