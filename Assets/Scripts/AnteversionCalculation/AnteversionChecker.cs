using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnteversionChecker : MonoBehaviour
{
    public bool CanCalculateAnteversion
    {
        get => landmarkData.GetLandmarkPositions().Count > 0;
        private set => CanCalculateAnteversion = value;
    }

    private LandmarkData landmarkData;

    public void SetLandmarkData(LandmarkData landmarkData)
    {
        this.landmarkData = landmarkData;
    }
}