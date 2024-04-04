using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointTrigger : MonoBehaviour
{
    public GameController gameController;

    private bool flag = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        flag = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (flag)
        {
            gameController.lap++;
            flag = false;
        }


    }
}
