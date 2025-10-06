using UnityEngine;

public class BubleExplota : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Mano")) // asegúrate de que la mano tenga tag "Mano"
        {
            Debug.Log("💥 ¡Burbuja explotó!");
            Destroy(gameObject); // destruye la burbuja
        }
    }
}