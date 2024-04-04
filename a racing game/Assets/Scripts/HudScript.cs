using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HudScript : MonoBehaviour
{

    public GameController gameController;
    public GameObject car;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<TextMeshProUGUI>().text = gameController.lap + " laps\n" + car.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().CurrentSpeed + " MPH";
    }
}
