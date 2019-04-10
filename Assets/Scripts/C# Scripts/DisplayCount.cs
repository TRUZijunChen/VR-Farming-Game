using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCount : MonoBehaviour
{
    public GameObject countText;

    private string objectName;
    Text displayCount;
    // Start is called before the first frame update
    void Start()
    {
        objectName = countText.name;
        Debug.Log("Current count text name is: " + objectName);
        displayCount = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (objectName) {
            case "cowCount":
                displayCount.text = DisplayCowNum.Lv1CowNum.ToString();
                break;
            case "pigCount":
                displayCount.text = DisplayPigNum.Lv1PigNum.ToString();
                break;
            case "cornCount":
                displayCount.text = DisplayCornNum.cornNum.ToString();
                break;
            case "wheatCount":
                displayCount.text = DisplayWheatNum.wheatNum.ToString();
                break;
            default:
                displayCount.text = "0";
                break;

        }
    }
}
