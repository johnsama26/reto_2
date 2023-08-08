using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform target; // El objeto al que "L" seguirá

    private void Update()
    {
        if (target != null)
        {
            // Actualizar la posición de "L" para que siga la posición de "M"
            transform.position = target.position;
        }
    }
}