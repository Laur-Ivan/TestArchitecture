using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnteversionManager : MonoBehaviour
{
    [SerializeField] private AnteversionChecker anteversionChecker;
    [SerializeField] private AnteversionCalculator anteversionCalculator;
    [SerializeField] private AnteversionUIHandler anteversionUIHandler;

    private LandmarkData landmarkData;

    private void Awake()
    {
        landmarkData = ServiceLocator.GetService<LandmarkData>();
        
        anteversionChecker.SetLandmarkData(landmarkData);
        anteversionCalculator.SetLandmarkData(landmarkData);
    }

    public void CalculateAnteversion()
    {
        if (anteversionChecker.CanCalculateAnteversion)
        {
            float anteversion = anteversionCalculator.CalculateAnteversion();
            anteversionUIHandler.UpdateAnteversionText(anteversion);
        }
        else
        {
            anteversionUIHandler.ShowErrorMessage();
        }
    }
}
