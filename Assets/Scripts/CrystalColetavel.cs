using UnityEngine;

public class CrystalColetavel : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            GameManager.instance.ColetarCristal();

            Destroy(gameObject);
        }
    }
    
}
