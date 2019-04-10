using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Upgrade : MonoBehaviour
{
    GameObject[] allObjects;
    List<GameObject> lvl1Cows = new List<GameObject>();
    List<GameObject> lvl1Pigs = new List<GameObject>();

    Text lvl1CowText;
    Text lvl2PigText;


    public CurrencySystem curr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        allObjects = Object.FindObjectsOfType<GameObject>(); //get all gameobjects

        foreach(GameObject go in allObjects) //for each game object
        {
            if(go.name.Contains("Lv1Cow")) //if name of object contains "Lv1Cow"
            {
                lvl1Cows.Add(go); //add to cow list
            }

            if(go.name.Contains("Lv1Pig")) //if name of object contains "Lv1Pig"
            {
                lvl1Pigs.Add(go); //add to pig list
            }
        }

        lvl1CowText.text = "Level 1 Cows: " + lvl1Cows.Count; //adjust total lvl1 cows
        lvl2PigText.text = "Level 1 Pigs: " + lvl1Pigs.Count; //adjust total lvl1 pigs

    }

    public void upgradeCow()
    {
        //check if there are any lvl1 cows to upgrade
        if (lvl1Cows.Count > 0)
        {
            //retreive any level 1 cow
            GameObject cowToUpgrade = lvl1Cows[0];
            //retrieve position of object
            //Vector3 positionOfOldCow = cowToUpgrade.Transform.position;
            //delete old cow
            Destroy(cowToUpgrade);
            //place new cow in spot of old one
            //Instantiate(Resources.Load("Lv2Cow"), positionOfOldCow, Quaternion.identity);
            //subtract money from user total
        }
        else
        {
            //no cows to upgrade
        }
        

    }

    public void upgradePig()
    {
        if (lvl1Pigs.Count > 0)
        {
            //retreive any level 1 pig
            GameObject pigToUpgrade = lvl1Pigs[0];
            //retrieve position of object
            //Vector3 positionOfOldPig = pigToUpgrade.Transform.position;
            //delete old cow
            Destroy(pigToUpgrade);
            //place new cow in spot of old one
            //Instantiate(Resources.Load("Lv2Pig"), positionOfOldPig, Quaternion.identity);
            //subtract money form user total
        }
        else
        {
            //no pigs to upgrade
        }
    }
}
