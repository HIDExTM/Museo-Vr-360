using UnityEngine;
using UnityEngine.UI;

public class ShowPanel : MonoBehaviour
{
    public GameObject panel; // El panel que deseas mostrar/ocultar
    public float displayDuration = 5f; // Duración en segundos

    private void Start()
    {
        panel.SetActive(false); // Asegúrate de que el panel esté inicialmente oculto
    }

    public void ShowPanelWithTimer()
    {
        panel.SetActive(true); // Mostrar el panel
        Invoke("HidePanel", displayDuration); // Ocultar el panel después de `displayDuration` segundos
    }

    private void HidePanel()
    {
        panel.SetActive(false); // Ocultar el panel
    }
}
