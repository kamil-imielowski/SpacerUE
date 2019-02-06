using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GUIText ectsText;
    private int ects;

    // Start is called before the first frame update
    void Start()
    {
        ects = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddEcts(int newEctsValue)
    {
        ects += newEctsValue;
        UpdateEcts();
    }

    void UpdateEcts()
    {
        ectsText.text = "Score: " + ects;
    }
}
