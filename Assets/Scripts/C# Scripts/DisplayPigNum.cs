using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPigNum : MonoBehaviour
{
    public static int Lv1PigNum;
    Text Lv1PigNumDisplay;
    // Start is called before the first frame update
    void Start()
    {
        Lv1PigNumDisplay = GetComponent<Text>();//get text component
        //initial cow number is 0
        Lv1PigNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Lv1PigNumDisplay.text = "Pig(LV.1): " + Lv1PigNum;
    }
}
