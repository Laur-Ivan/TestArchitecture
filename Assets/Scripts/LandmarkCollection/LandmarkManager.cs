using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandmarkManager : MonoBehaviour
{
    [SerializeField] private LandmarkPositioner landmarkPositioner;
    [SerializeField] private LandmarkChecker landmarkChecker;
    [SerializeField] private LandmarkUIHandler landmarkUIHandler;
    [SerializeField] private LandmarkData landmarkData;
    
    public void CollectLandmark()
    {
        if (landmarkChecker.CanCollectLandmark)
        {
            Vector3 landmarkPosition = landmarkPositioner.GetLandmarkPosition();
            landmarkData.AddLandmarkPositionToList(landmarkPosition);
            landmarkUIHandler.UpdateLandmarkCollectedText(landmarkPosition);
        }
    }
}
