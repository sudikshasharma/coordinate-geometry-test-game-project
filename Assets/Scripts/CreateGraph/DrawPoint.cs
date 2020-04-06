using UnityEngine;

public class DrawPoint : MonoBehaviour
{
    PlotPoint point;
    void Start()
    {
        point = new PlotPoint(0, 0);
        point.DrawPoint(0.1f, Color.magenta, new Vector3(0.1f, -3, -1));
        //Draw line renderer line
        //Draw X axis
        point.DrawLine(new Vector3(-100, 0, -1), new Vector3(100, 0, -1), 0.1f, Color.red);
        //Draw Y axis
        point.DrawLine(new Vector3(0, -100, -1), new Vector3(0, 100, -1), 0.1f, Color.green);
    }
    void Update()
    {
        //Draw console line
        point.DrawConsoleLine(new Vector3(0, 0, -1), new Vector3(5, 5, -1));
    }
}
