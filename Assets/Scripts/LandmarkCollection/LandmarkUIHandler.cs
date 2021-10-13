using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LandmarkUIHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI landmarkCollectedText;

    public void UpdateLandmarkCollectedText(Vector3 landmarkPosition)
    {
        landmarkCollectedText.text = $"Collected landmark placed at {landmarkPosition}";
    }
}
