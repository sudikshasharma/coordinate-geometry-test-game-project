using UnityEngine;
public class PlotPoint
{
    int x;
    int y;
    int z;
    public PlotPoint(int _x, int _y)
    {
        x = _x;
        y = _y;
        z = -1;
    }
    public void DrawPoint(float width, Color color, Vector2 pos)
    {
        GameObject point = new GameObject("PointObj");
        LineRenderer lineR = point.AddComponent<LineRenderer>();
        lineR.startWidth = width;
        lineR.endWidth = width;
        lineR.material = new Material(Shader.Find("Unlit/Color"));
        lineR.material.color = color;
        lineR.positionCount = 2;
        //Making point visible
        lineR.SetPosition(0, pos);
        lineR.SetPosition(1, new Vector3(pos.x + 0.1f, pos.y + 0.1f, -1));
    }
    public void DrawConsoleLine(Vector3 pos1, Vector3 pos2)
    {
        Debug.DrawLine(pos1, pos2, Color.black);
    }
    public void DrawLine(Vector3 pos1, Vector3 pos2, float width, Color color)
    {
        GameObject ray = new GameObject("PointObj");
        LineRenderer lineR = ray.AddComponent<LineRenderer>();
        lineR.startWidth = width;
        lineR.endWidth = width;
        lineR.material = new Material(Shader.Find("Unlit/Color"));
        lineR.material.color = color;
        lineR.positionCount = 2;
        lineR.SetPosition(0, pos1);
        lineR.SetPosition(1, pos2);
    }

}
