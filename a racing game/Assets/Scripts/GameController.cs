using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{

    public GameObject map1;
    public GameObject map2;
    public GameObject car1;
    public GameObject car2;

    private GameObject _selectedMap;
    private GameObject _selectedCar;

    public GameObject HudText;

    public TMP_Text CarChoiceText;
    public TMP_Text MapChoiceText;
    public TMP_Text WarningText;

    public GameObject OverScreen;

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
            EndGame(OverScreen);
        }
        
    }

    public void SetMapOnActive(GameObject map)
    {
        _selectedMap = map;
        MapChoiceText.text = "Map Choice: " + map.name;
    }

    public void SetCarOnActive(GameObject car)
    {
        _selectedCar = car;
        CarChoiceText.text = "Car Choice: " + car.name;
        HudText.GetComponentInChildren<HudScript>().car = car;
    }

    public void StartGame(GameObject ui)
    {
        if(_selectedCar!=null && _selectedMap != null)
        {
            HudText.SetActive(true);
            _selectedCar.SetActive(true);
            _selectedMap.SetActive(true);
            ui.SetActive(false);
        }
        else
        {
            WarningText.gameObject.SetActive(true);
        }
    }

    public void EndGame(GameObject ui)
    {
        HudText.SetActive(false);
        _selectedCar.SetActive(false);
        _selectedMap.SetActive(false);
        ui.SetActive(true);
    }
}
