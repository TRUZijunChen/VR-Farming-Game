using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarketplaceActions : MonoBehaviour
{
    public Vector3 animalArea1;
    public Vector3 animalArea2;
    public Vector3 cropArea;
    // Whether the Google Cardboard user is gazing at this button.
    private bool isLookedAt = false;
    // Count time the player has been gazing at the button.
    private float lookTimer = 0f;
    // How long the user can gaze at this before the button is clicked.
    public float timerDuration = 3f;
    private bool clicked;
    private string deleteTarget;
    // Start is called before the first frame update
    void Start()
    {
        clicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        // While player is looking at this button.
        if (isLookedAt)
        {

            // Increment the gaze timer.
            lookTimer += Time.deltaTime;


            // Gaze time exceeded limit - button is considered clicked.
            if (lookTimer > timerDuration)
            {

                if (clicked == false)
                {
                    Debug.Log("clicked on this object");
                    GetComponent<Button>().onClick.Invoke();
                    clicked = true;
                }
            }
        }

        // Not gazing at this anymore, reset everything.
        else
        {
            lookTimer = 0f;
            clicked = false;
        }
    }

    public void buyCow()
    {
        //If true, subtract money from total and add new cow to scene
        if(GetComponent<CurrencySystem>().subtractMoney(150))
        {
            Debug.Log("Bought Cow");
            animalArea1 = new Vector3(Random.Range(10.19f, 15.52f), 3.5f, Random.Range(5.85f, 10.98f));
            var cow = Instantiate(Resources.Load("Lv1Cow"), animalArea1, Quaternion.identity);
            cow.name = "Lv1cow_" + IdGenerator.getNewID() ;
            DisplayCowNum.Lv1CowNum++;
            AnimalCornManager.manager.Add(cow.name);
            Debug.Log("stuff in the list: ");
            foreach(string stuff in AnimalCornManager.manager){
                Debug.Log(stuff);
            }
        }
        else
        {
            //not enough money!
        }
        
    }

    public void buyPig()
    {
        Debug.Log("Bought pig");
        //If true, subtract money from total and add new pig to scene
        if (GetComponent<CurrencySystem>().subtractMoney(150))
        {
            animalArea2 = new Vector3(Random.Range(5.32f, 10.33f), 3.5f, Random.Range(11.79f, 16.70f));
            var pig = Instantiate(Resources.Load("Lv1Pig"), animalArea2, Quaternion.identity);
            pig.name = "Lv1pig_" + IdGenerator.getNewID();
            DisplayPigNum.Lv1PigNum++;

            AnimalCornManager.manager.Add(pig.name);
            Debug.Log("stuff in the list: ");
            foreach (string stuff in AnimalCornManager.manager)
            {
                Debug.Log(stuff);
            }
        }
    }

    public void buyCorn()
    {
        //If true, subtract money from total and add new corn to scene
        if (GetComponent<CurrencySystem>().subtractMoney(50))
        {
            Debug.Log("Bought Corn");
            cropArea = new Vector3(Random.Range(17f, 24.5f), 3.36f, Random.Range(25.5f, 29.5f));
            var corn = Instantiate(Resources.Load("corn"), cropArea, Quaternion.identity);
            corn.name = "corn_" + IdGenerator.getNewID();
            DisplayCornNum.cornNum++;

            AnimalCornManager.manager.Add(corn.name);
            Debug.Log("stuff in the list: ");
            foreach (string stuff in AnimalCornManager.manager)
            {
                Debug.Log(stuff);
            }
        }

    }

    public void buyWheat()
    {
        //If true, subtract money from total and add new wheat to scene
        if (GetComponent<CurrencySystem>().subtractMoney(50))
        {
            Debug.Log("Bought Wheat");
            cropArea = new Vector3(Random.Range(17f, 24.5f), 3.36f, Random.Range(25.5f, 29.5f));
            var wheat = Instantiate(Resources.Load("bunchofwheats"), cropArea, Quaternion.identity);
            wheat.name = "wheat_" + IdGenerator.getNewID();
            DisplayWheatNum.wheatNum++;

            AnimalCornManager.manager.Add(wheat.name);
            Debug.Log("stuff in the list: ");
            foreach (string stuff in AnimalCornManager.manager)
            {
                Debug.Log(stuff);
            }
        }

    }

    public void sellLv1Cow() {

        if (DisplayCowNum.Lv1CowNum > 0) {
            GetComponent<CurrencySystem>().addMoney(120);
        
            Debug.Log("sold cow");
            string compareStr = "Lv1cow";
            //loop through the list find out lv1cow
            foreach (string stuff in AnimalCornManager.manager) {
                string str = stuff.Substring(0, 6);
                Debug.Log("first 6 characters are: " + str);
                if (string.Compare(str, compareStr) == 0) {
                    deleteTarget = stuff;
                    AnimalCornManager.manager.Remove(stuff);
                    Destroy(GameObject.Find(stuff));
                    Debug.Log("Deleted object: " + stuff);
                    DisplayCowNum.Lv1CowNum--;
                    break;
                }
            }
        }
        
         Debug.Log("stuff in the list: ");
         foreach (string stuff in AnimalCornManager.manager)
         {
                Debug.Log(stuff);
         }
        

    }

    public void sellLv1Pig()
    {

        if (DisplayPigNum.Lv1PigNum > 0)
        {
            GetComponent<CurrencySystem>().addMoney(120);

            Debug.Log("sold pig");
            string compareStr = "Lv1pig";
            //loop through the list find out lv1cow
            foreach (string stuff in AnimalCornManager.manager)
            {
                string str = stuff.Substring(0, 6);
                Debug.Log("first 6 characters are: " + str);
                if (string.Compare(str, compareStr) == 0)
                {
                    deleteTarget = stuff;
                    AnimalCornManager.manager.Remove(stuff);
                    Destroy(GameObject.Find(stuff));
                    Debug.Log("Deleted object: " + stuff);
                    DisplayPigNum.Lv1PigNum--;
                    break;
                }
            }
        }

        Debug.Log("stuff in the list: ");
        foreach (string stuff in AnimalCornManager.manager)
        {
            Debug.Log(stuff);
        }


    }

    public void sellCorn()
    {

        if (DisplayCornNum.cornNum> 0)
        {
            GetComponent<CurrencySystem>().addMoney(30);

            Debug.Log("sold corn");
            string compareStr = "corn";
            //loop through the list find out lv1cow
            foreach (string stuff in AnimalCornManager.manager)
            {
                string str = stuff.Substring(0, 4);
                Debug.Log("first 4 characters are: " + str);
                if (string.Compare(str, compareStr) == 0)
                {
                    deleteTarget = stuff;
                    AnimalCornManager.manager.Remove(stuff);
                    Destroy(GameObject.Find(stuff));
                    Debug.Log("Deleted object: " + stuff);
                    DisplayCornNum.cornNum--;
                    break;
                }
            }
        }

        Debug.Log("stuff in the list: ");
        foreach (string stuff in AnimalCornManager.manager)
        {
            Debug.Log(stuff);
        }


    }

    public void sellwheat()
    {

        if (DisplayWheatNum.wheatNum > 0)
        {
            GetComponent<CurrencySystem>().addMoney(30);

            Debug.Log("sold wheat");
            string compareStr = "wheat";
            //loop through the list find out wheat
            foreach (string stuff in AnimalCornManager.manager)
            {
                string str = stuff.Substring(0, 5);
                Debug.Log("first 5 characters are: " + str);
                if (string.Compare(str, compareStr) == 0)
                {
                    deleteTarget = stuff;
                    AnimalCornManager.manager.Remove(stuff);
                    Destroy(GameObject.Find(stuff));
                    Debug.Log("Deleted object: " + stuff);
                    DisplayWheatNum.wheatNum--;
                    break;
                }
            }
        }

        Debug.Log("stuff in the list: ");
        foreach (string stuff in AnimalCornManager.manager)
        {
            Debug.Log(stuff);
        }


    }

    public void SetGazedAt(bool gazedAt)
    {
        isLookedAt = gazedAt;
    }
}
