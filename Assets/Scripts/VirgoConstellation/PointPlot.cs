using UnityEngine;

public class PointPlot
{
    float x;
    float y;
    float z;
    public PointPlot(float _x, float _y)
    {
        x = _x;
        y = _y;
    }

    public void DrawConstellation(float width, Color color, Vector3 startPos, Vector3 endPos)
    {
        GameObject virgoC = new GameObject("VirgoC");
        LineRenderer lineR = virgoC.AddComponent<LineRenderer>();
        lineR.material = new Material(Shader.Find("Unlit/Color"));
        lineR.material.color = color;
        lineR.startWidth = width;
        lineR.endWidth = width;
        lineR.positionCount = 2;
        lineR.SetPosition(0, startPos);
        lineR.SetPosition(1, endPos);
    }
}
