using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyAppManager : MonoBehaviour
{
    private LandmarkManager landmarkManager;
    private AnteversionManager anteversionManager;
    
    private void Awake()
    {
        landmarkManager = ServiceLocator.GetService<LandmarkManager>();
        anteversionManager = ServiceLocator.GetService<AnteversionManager>();
    }

    public void CollectLandmark()
    {
        landmarkManager.CollectLandmark();
    }

    public void CalculateAnteversion()
    {
        anteversionManager.CalculateAnteversion();
    }
}
