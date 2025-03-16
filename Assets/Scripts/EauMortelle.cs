using System.Collections;
using UnityEngine;

public class EauMortelle : MonoBehaviour
{
    public Transform pointDeRespawn; // Point où le joueur réapparaît

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Le joueur est tombé dans l'eau !");

            CharacterController cc = other.GetComponent<CharacterController>();
            if (cc != null)
            {
                cc.enabled = false; // Désactiver le CharacterController
                other.transform.position = pointDeRespawn.position;
                cc.enabled = true; // Le réactiver après le respawn
            }
            else
            {
                other.transform.position = pointDeRespawn.position;
            }
        }
    }
}
