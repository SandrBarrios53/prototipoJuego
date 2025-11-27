using UnityEngine;

public class SpawnerPelotas : MonoBehaviour
{
    public GameObject pelotaPrefab; // Asigna aquí el prefab, NO la instancia de la escena
    public float tiempo = 2f;

    void Start()
    {
        if(pelotaPrefab == null)
        {
            Debug.LogError("No se ha asignado el prefab de la pelota!");
            return;
        }
        InvokeRepeating("CrearPelota", 1f, tiempo);
    }

    void CrearPelota()
    {
        Vector3 pos = new Vector3(Random.Range(-8f, 198f), 19f, Random.Range(-8f, 198f));
        Instantiate(pelotaPrefab, pos, Quaternion.identity);
    }
}
