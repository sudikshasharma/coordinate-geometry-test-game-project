using UnityEngine;

public class DrawGraph : MonoBehaviour
{
    public float width = 5f;
    PlotPoint point;
    void Start()
    {
        Debug.Log(Screen.width);
        point = new PlotPoint(0, 0);
        point.DrawPoint(0.1f, Color.white, Vector3.zero);
        point.DrawLine(new Vector3(-100, 0, -1), new Vector3(100, 0, -1), 0.3f, Color.red);
        point.DrawLine(new Vector3(0, -100, -1), new Vector3(0, 100, -1), 0.3f, Color.green);
        DrawLines();
    }

    void DrawLines()
    {
        bool isEven = true;
        float width = this.width;
        float lineWidth;
        int count = 5;
        int i = 0;
        while (i < count)
        {
            if (isEven)
            {
                lineWidth = 0.1f;
            }
            else
            {
                lineWidth = 0.2f;
            }
            point.DrawLine(new Vector3(-100, width, -1), new Vector3(100, width, -1), lineWidth, Color.black);
            point.DrawLine(new Vector3(-100, -width, -1), new Vector3(100, -width, -1), lineWidth, Color.black);
            isEven = !isEven; ++i;
            width += this.width;
        }
    }
}

