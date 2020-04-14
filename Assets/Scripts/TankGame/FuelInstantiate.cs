using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelInstantiate : MonoBehaviour
{
    public GameObject fuel;
    void Start()
    {
        GameObject fuelObj = Instantiate(fuel, new Vector3(Random.Range(-100, 100), Random.Range(-100, 100), this.gameObject.transform.position.z), Quaternion.identity);
        Debug.Log("Fuel location: " + fuelObj.transform.position);
    }
}
