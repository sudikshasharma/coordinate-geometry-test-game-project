using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawConstellation : MonoBehaviour
{
    void Start()
    {
        PointPlot point = new PointPlot(0, 0);
        Vector3[] virgoPoints = new Vector3[]{
            new Vector3(0,0,-1),
            new Vector3(1,0,-1),
            new Vector3(2.2f,1,-1),
            new Vector3(1.5f,1.6f,-1),
            new Vector3(0,1.6f,-1),
            new Vector3(3.5f,0.8f,-1),
            new Vector3(3.1f,2f,-1),
            new Vector3(2.7f,3f,-1),
            new Vector3(4f,0.9f,-1f),
            new Vector3(4.2f,2.8f,-1),
            new Vector3(4.5f,2.7f,-2),
            new Vector3(4.4f,2.2f,-1),
            new Vector3(2.3f,-1f,-1),
            new Vector3(2f,-1.6f,-1),
        };

        foreach (var pointt in virgoPoints)
        {
            point.DrawConstellation(0.1f, Color.red, pointt, new Vector3(pointt.x + 0.05f, pointt.y + 0.05f, -1));
        }
        point.DrawConstellation(0.05f, Color.black, virgoPoints[0], virgoPoints[1]);
        point.DrawConstellation(0.05f, Color.black, virgoPoints[1], virgoPoints[2]);
        point.DrawConstellation(0.05f, Color.black, virgoPoints[2], virgoPoints[3]);
        point.DrawConstellation(0.05f, Color.black, virgoPoints[3], virgoPoints[4]);
        point.DrawConstellation(0.05f, Color.black, virgoPoints[2], virgoPoints[5]);
        point.DrawConstellation(0.05f, Color.black, virgoPoints[5], virgoPoints[6]);
        point.DrawConstellation(0.05f, Color.black, virgoPoints[6], virgoPoints[7]);
        point.DrawConstellation(0.05f, Color.black, virgoPoints[5], virgoPoints[8]);
        point.DrawConstellation(0.05f, Color.black, virgoPoints[8], virgoPoints[9]);
        point.DrawConstellation(0.05f, Color.black, virgoPoints[9], virgoPoints[10]);
        point.DrawConstellation(0.05f, Color.black, virgoPoints[10], virgoPoints[11]);
        point.DrawConstellation(0.05f, Color.black, virgoPoints[8], virgoPoints[11]);
        point.DrawConstellation(0.05f, Color.black, virgoPoints[5], virgoPoints[12]);
        point.DrawConstellation(0.05f, Color.black, virgoPoints[12], virgoPoints[13]);
    }
}
