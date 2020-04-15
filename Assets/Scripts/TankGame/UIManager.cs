using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public Transform tank;
    [HideInInspector] public Transform fuel;
    public Text tankPos;
    public Text fuelPos;
    public Text fuelLeft;
    public Text fuelAmount;
    void Start()
    {
        tankPos.text = tank.position.ToString();
        fuelPos.text = tank.GetComponent<FuelInstantiate>().fuelPos.ToString();
    }
    public void InputFuel()
    {
        int n;
        if (int.TryParse(fuelAmount.text.ToString(), out n))
        {
            fuelLeft.text = fuelAmount.text.ToString();
        }
    }
}
