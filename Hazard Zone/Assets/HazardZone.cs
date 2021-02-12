using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardZone : MonoBehaviour
{
    public Transform respawnPoint;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            CharacterController cc = other.GetComponent<CharacterController>();
            cc.enabled = false;
            other.transform.position = respawnPoint.position;
            cc.enabled = true;
        }
    }
}
