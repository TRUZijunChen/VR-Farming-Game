using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Upgrade : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void upgradeCow()
    {
        //check if there are any lvl1 cows to upgrade
        //check corn too
        if (DisplayCowNum.Lv1CowNum > 0 && DisplayCornNum.cornNum > 0 && GetComponent<CurrencySystem>().subtractMoney(20))
        {

            Debug.Log("upgrade cow");
            string compareStr = "Lv1cow";
            //loop through the list find out lv1cow
            foreach (string stuff in AnimalCornManager.manager)
            {
                string str = stuff.Substring(0, 6);
                Debug.Log("first 6 characters are: " + str);
                if (string.Compare(str, compareStr) == 0)
                {
                    string deleteTarget = stuff;
                    AnimalCornManager.manager.Remove(stuff);
                    Destroy(GameObject.Find(stuff));
                    Debug.Log("Deleted object: " + stuff);
                    DisplayCowNum.Lv1CowNum--;
                    break;
                }

            }

            //loop through the list to find out corn
            foreach (string corn in AnimalCornManager.manager) {

                string str = corn.Substring(0,4);
                if (string.Compare(str, "corn") == 0)
                {
                    AnimalCornManager.manager.Remove(corn);
                    Destroy(GameObject.Find(corn));
                    Debug.Log("spent a corn: " + corn);
                    DisplayCornNum.cornNum--;
                    break;
                }
            }

            //instanciate lv2 cow
            Vector3 animalArea1 = new Vector3(Random.Range(10.19f, 15.52f), 3.5f, Random.Range(5.85f, 10.98f));
            var cow = Instantiate(Resources.Load("Lv2Cow"), animalArea1, Quaternion.identity);
            cow.name = "Lv2cow_" + IdGenerator.getNewID();
            DisplayLv2CowNum.Lv2CowNum++;
            AnimalCornManager.manager.Add(cow.name);

        }
        else
        {
            Debug.Log("no cow to upgrade.");
        }
        

    }

    public void upgradePig()
    {
        //check if there are any lvl1 cows to upgrade
        //check corn too
        if (DisplayPigNum.Lv1PigNum > 0 && DisplayWheatNum.wheatNum > 0 && GetComponent<CurrencySystem>().subtractMoney(20))
        {

            Debug.Log("upgrade pig");
            string compareStr = "Lv1pig";
            //loop through the list find out lv1pig
            foreach (string p in AnimalCornManager.manager)
            {
                string str = p.Substring(0, 6);
                Debug.Log("first 6 characters are: " + str);
                if (string.Compare(str, compareStr) == 0)
                {
                    AnimalCornManager.manager.Remove(p);
                    Destroy(GameObject.Find(p));
                    Debug.Log("Deleted object: " + p);
                    DisplayPigNum.Lv1PigNum--;
                    break;
                }

            }

            //loop through the list to find out corn
            foreach (string wheat in AnimalCornManager.manager)
            {

                string str = wheat.Substring(0, 5);
                if (string.Compare(str, "wheat") == 0)
                {
                    AnimalCornManager.manager.Remove(wheat);
                    Destroy(GameObject.Find(wheat));
                    Debug.Log("spent a corn: " + wheat);
                    DisplayWheatNum.wheatNum--;
                    break;
                }
            }

            //instanciate lv2 pig
            Vector3 animalArea2 = new Vector3(Random.Range(5.32f, 10.33f), 3.5f, Random.Range(11.79f, 16.70f));
            var pig = Instantiate(Resources.Load("Lv2Pig"), animalArea2, Quaternion.identity);
            pig.name = "Lv2pig_" + IdGenerator.getNewID();
            DisplayLv2PigNum.Lv2PigNum++;

            AnimalCornManager.manager.Add(pig.name);

        }
        else
        {
            Debug.Log("no pig to upgrade.");
        }
    }
}
