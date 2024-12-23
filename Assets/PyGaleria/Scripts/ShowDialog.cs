using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ShowDialog : MonoBehaviour
{
    public GameObject dialogPanel;  // El panel que contiene el diálogo
    public Text dialogText;         // El texto del diálogo
    public string message;          // El mensaje que se mostrará
    public Button showDialogButton; // El botón que muestra el diálogo
    public Button viewButton;       // El botón "Ver" que aparecerá y desaparecerá junto con el diálogo

    private void Start()
    {
        dialogPanel.SetActive(false);  // Asegúrate de que el panel esté desactivado al inicio
        viewButton.gameObject.SetActive(false);  // Asegúrate de que el botón "Ver" esté desactivado al inicio

        if (showDialogButton != null)
        {
            showDialogButton.onClick.AddListener(ShowMessage);  // Asigna la función ShowMessage al evento OnClick del botón original
        }
    }

    public void ShowMessage()
    {
        StartCoroutine(DisplayDialog());
    }

    private IEnumerator DisplayDialog()
    {
        dialogPanel.SetActive(true);   // Muestra el panel
        dialogText.text = message;     // Establece el mensaje
        viewButton.gameObject.SetActive(true);  // Muestra el botón "Ver"
        yield return new WaitForSeconds(3);  // Espera 3 segundos
        dialogPanel.SetActive(false);  // Oculta el panel
        viewButton.gameObject.SetActive(false);  // Oculta el botón "Ver"
    }
}
