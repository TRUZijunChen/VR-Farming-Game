using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayLv2CowNum : MonoBehaviour
{
    public static int Lv2CowNum;
    Text Lv2CowNumDisplay;
    // Start is called before the first frame update
    void Start()
    {
        Lv2CowNumDisplay = GetComponent<Text>();//get text component
        //initial cow number is 0
        Lv2CowNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Lv2CowNumDisplay.text = "Lv2 Cow: " + Lv2CowNum;
    }
}
