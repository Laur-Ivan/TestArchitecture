using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandmarkPositioner : MonoBehaviour
{
    public Vector3 GetLandmarkPosition()
    {
        Vector3 landmarkPosition = Input.mousePosition;
        
        Debug.Log($"Landmark position is {landmarkPosition}");
        
        return landmarkPosition;
    }
}
