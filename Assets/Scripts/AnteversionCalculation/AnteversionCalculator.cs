using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AnteversionCalculator : MonoBehaviour
{
    private LandmarkData landmarkData;

    public void SetLandmarkData(LandmarkData landmarkData)
    {
        this.landmarkData = landmarkData;
    }

    public float CalculateAnteversion()
    {
        List<Vector3> landmarkPositions = landmarkData.GetLandmarkPositions();
        
        return landmarkPositions.Average(position => position.x);
    }
}
