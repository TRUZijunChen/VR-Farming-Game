using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayWheatNum : MonoBehaviour
{
    public static int wheatNum;
    Text wheatNumDisplay;
    // Start is called before the first frame update
    void Start()
    {
        wheatNumDisplay = GetComponent<Text>();//get text component
        //initial cow number is 0
        wheatNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        wheatNumDisplay.text = "Wheat: " + wheatNum;
    }
}
