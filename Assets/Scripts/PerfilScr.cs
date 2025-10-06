using UnityEngine;
 using TMPro;

public class PerfilManager : MonoBehaviour
{
    [Header("UI Elements")]
    public GameObject panelPerfil;
    public TextMeshProUGUI textoNombre;
    public TextMeshProUGUI textoEdad;
    public TextMeshProUGUI textoPeso;
    public TextMeshProUGUI textoBarthel;

    [Header("Profile Data")]
    public string nombre = "Default Name";
    public int edad = 0;
    public float peso = 0f;
    public int barthel = 0;

    private void Start()
    {
        panelPerfil?.SetActive(false);
    }

    public void AbrirPerfil()
    {
        panelPerfil.SetActive(true);
        textoNombre.text = "Nombre: " + nombre;
        textoEdad.text = "Edad: " + edad.ToString();
        textoPeso.text = "Peso: " + peso.ToString("F1") + " kg";
        textoBarthel.text = "Escala de Barthel: " + barthel.ToString();
    }

    public void CerrarPerfil()
   {
    panelPerfil?.SetActive(false);
   }
}