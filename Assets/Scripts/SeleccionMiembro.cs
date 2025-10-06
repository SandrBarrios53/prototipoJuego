using UnityEngine;
using UnityEngine.SceneManagement;

public class SeleccionMiembro : MonoBehaviour
{
    
    public static string miembroSeleccionado = "";


    public void SeleccionarMiembro(string miembro)
    {
        miembroSeleccionado = miembro;
        Debug.Log("Miembro seleccionado: " + miembroSeleccionado);

        SceneManager.LoadScene("EscenaJuego");
    }
}

