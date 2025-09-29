using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PathManager : MonoBehaviour
{
[HideInInspector]
    [SerializeField] public List<Waypoint> path;

    public GameObject prefab;
    int currentPointIndex = 0;

    public List<GameObject> prefabPoints;
    public List<Waypoint> GetPath()
    {
        if (path == null)
            path = new List<Waypoint>();

        return path;
    }

    public void CreateAddPoint()
    {
        Waypoint go = new Waypoint();
        path.Add(go);
    }

    public Waypoint GetNextTarget()
    {
        int nextPointIndex = (currentPointIndex + 1) % (path.Count);
        currentPointIndex = nextPointIndex;
        return path[nextPointIndex];
    }

}
