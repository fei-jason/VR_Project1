using System.Collections;
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



    // Start is called before the first frame update
    void Start()
    {
        currEnergy = maxEnergy;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = (float)currEnergy / maxEnergy;

        if (currEnergy > maxEnergy)
        {
            currEnergy = maxEnergy;
        }
    }


    public void RemoveEnergy()
    {
        currEnergy -= 25;
    }

}


