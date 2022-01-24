using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = new Vector3(-1334, 132, -246);
    }
}