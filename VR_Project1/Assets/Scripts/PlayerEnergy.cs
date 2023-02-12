using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEnergy : MonoBehaviour
{

    public int maxEnergy = 100;
    private int currEnergy;
    public GameObject energyUi;
    public Slider slider;

    float timer;
    int waitingTime = 3;



    // Start is called before the first frame update
    void Start()
    {
        currEnergy = 0;
    }

    // Update is called once per frame
    void Update()
    {

        slider.value = (float)currEnergy / maxEnergy;

        if (currEnergy > maxEnergy)
        {
            currEnergy = maxEnergy;
        }

        timer += Time.deltaTime;
        if (timer > waitingTime)
        {
            currEnergy += 25;
            timer = 0;
        }


    }


    public void RemoveEnergy()
    {
        currEnergy -= 25;
    }

}


