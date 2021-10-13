using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnteversionUIHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI anteversionText;

    public void UpdateAnteversionText(float anteversion)
    {
        anteversionText.text = $"Anteversion is {anteversion} degrees";
    }

    public void ShowErrorMessage()
    {
        anteversionText.text = $"No landmark has been collected";
    }
}
