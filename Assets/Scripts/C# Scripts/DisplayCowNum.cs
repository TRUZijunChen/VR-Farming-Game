using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCowNum : MonoBehaviour
{
    public static int Lv1CowNum;
    Text Lv1CowNumDisplay;
    // Start is called before the first frame update
    void Start()
    {
        Lv1CowNumDisplay = GetComponent<Text>();//get text component
        //initial cow number is 0
        Lv1CowNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Lv1CowNumDisplay.text = "Cow(LV.1): " + Lv1CowNum;
    }
}
