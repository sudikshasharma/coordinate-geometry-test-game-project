using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform tank;
    void Update()
    {
        gameObject.transform.position = new Vector3(tank.position.x, tank.position.y, this.transform.position.z);
    }
}
