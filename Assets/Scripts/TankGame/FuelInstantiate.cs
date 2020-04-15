using UnityEngine;

public class FuelInstantiate : MonoBehaviour
{
    public GameObject fuel;
    [HideInInspector] public Vector3 fuelPos;
    void Awake()
    {
        GameObject fuelObj = Instantiate(fuel, new Vector3(Random.Range(-100, 100), Random.Range(-100, 100), this.gameObject.transform.position.z), Quaternion.identity);
        fuelPos = fuelObj.transform.position;
    }
}
