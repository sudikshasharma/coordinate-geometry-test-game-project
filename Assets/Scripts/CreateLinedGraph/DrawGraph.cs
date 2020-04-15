using UnityEngine;

public class DrawGraph : MonoBehaviour
{
    public float width = 5f;
    PlotPoint point;
    void Start()
    {
        Debug.Log(Screen.width);
        point = new PlotPoint(0, 0);
        point.DrawLine(new Vector3(-8, 0, -1), new Vector3(8, 0, -1), 0.1f, Color.red);
        point.DrawLine(new Vector3(0, -(8 * 10 / 16), -1), new Vector3(0, (8 * 10 / 16), -1), 0.1f, Color.green); //(8*10/16 = 5) calculating screen width with given ratio 16:10 and height as 8
        point.DrawPoint(0.1f, Color.white, Vector3.zero);
        DrawLines();
    }

    void DrawLines()
    {
        float offsetx = 8 - width;
        float offsety = 5 - width;
        for (float i = (-5 + offsety) * 2; i <= 5; i += width)
        {
            point.DrawLine(new Vector3(-8, i, -1), new Vector3(8, i, -1), 0.05f, Color.white);
        }
        for (float i = (-8 + offsetx) * 2; i <= 8; i += width)
        {
            point.DrawLine(new Vector3(i, 5, -1), new Vector3(i, -5, -1), 0.05f, Color.grey);
        }
    }
}

