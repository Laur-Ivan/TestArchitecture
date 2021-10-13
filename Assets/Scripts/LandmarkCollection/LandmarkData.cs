using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandmarkData : MonoBehaviour
{
    private List<Vector3> landmarkPositions = new List<Vector3>();

    public void AddLandmarkPositionToList(Vector3 landmarkPosition)
    {
        Debug.Log($"Adding landmark position to list");
        landmarkPositions.Add(landmarkPosition);
    }

    public List<Vector3> GetLandmarkPositions()
    {
        return landmarkPositions;
    }
}
