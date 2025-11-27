using UnityEngine;

public class PuntosPelota : MonoBehaviour
{
    public static int puntos = 0;

    void OnMouseEnter()
    {
        puntos++;
        Destroy(gameObject);
        Debug.Log("Puntos: " + puntos);
    }
}
