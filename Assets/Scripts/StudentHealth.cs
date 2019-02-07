using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StudentHealth : MonoBehaviour
{
    public int startingEcts = 0; // startuje od 0 ects
    public int currentEcts;
    public Slider EctsSlider;

    bool isPass;
    bool pass;


    private void Awake()
    {
        currentEcts = startingEcts;
    }

    // Update is called once per frame
    void Update()
    {
        if (pass)
        {
            // jakis efekt????
        }
        else
        {
            // powrot do normalnosci?
        }

        pass = false;
    }

    public void TakeEcts(int amount)
    {
        pass = true;
        currentEcts += amount;
        EctsSlider.value = currentEcts;
        if(currentEcts >= 30 && !isPass)
        {
            Pass();
        }
    }

    void Pass()
    {
        isPass = true;
    }
}
