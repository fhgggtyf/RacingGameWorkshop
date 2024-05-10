using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointTrigger : MonoBehaviour
{
    [SerializeField] private bool isFinish;

    public GameController gameController;

    public CheckPointTrigger prevPoint;

    private bool hitPrev;
    private bool notCounted = false;
    public bool hit;

    // Start is called before the first frame update
    void Start()
    {
        if (isFinish)
        {
            hit = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        hitPrev = prevPoint.hit;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (hitPrev)
        {
            hit = true;
            prevPoint.hit = false;
            hitPrev = false;
            notCounted = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (hit)
        {
            if (isFinish && notCounted)
            {
                gameController.lap++;
                notCounted = false;
            }

        }


    }
}
