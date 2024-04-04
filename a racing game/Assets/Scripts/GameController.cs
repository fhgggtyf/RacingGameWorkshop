using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject map1;
    public GameObject map2;
    public GameObject car1;
    public GameObject car2;

    private GameObject _selectedMap;
    private GameObject _selectedCar;

    public GameObject HudText;

    public int lap = 0;


    // Start is called before the first frame update
    void Start()
    {       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lap >= 3)
        {
            Debug.Log("yes");
        }
        
    }

    public void SetMapOnActive(GameObject map)
    {
        _selectedMap = map;
    }

    public void SetCarOnActive(GameObject car)
    {
        _selectedCar = car;
        HudText.GetComponent<HudScript>().car = car;
    }

    public void StartGame(GameObject ui)
    {
        HudText.SetActive(true);
        _selectedCar.SetActive(true);
        _selectedMap.SetActive(true);
        ui.SetActive(false);
    }
}
