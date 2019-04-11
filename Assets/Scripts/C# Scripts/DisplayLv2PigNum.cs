using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayLv2PigNum : MonoBehaviour
{
    public static int Lv2PigNum;
    Text Lv2PigNumDisplay;
    // Start is called before the first frame update
    void Start()
    {
        Lv2PigNumDisplay = GetComponent<Text>();//get text component
        //initial cow number is 0
        Lv2PigNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Lv2PigNumDisplay.text = "Lv2 Pig: " + Lv2PigNum;
    }
}
