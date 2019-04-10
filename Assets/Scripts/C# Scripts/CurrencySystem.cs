﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencySystem : MonoBehaviour
{
    public static int currentMoney; //current amount held by user
    Text money;
    //float time = 600f; //time in seconds for money generation
    float time = 30f;
    // Start is called before the first frame update
    void Start()
    {
        money = GetComponent<Text>();
        currentMoney = 500; //set default money at start of game
    }

    // Update is called once per frame
    void Update()
    {
        money.text = "$ " + currentMoney;
        moneyTimer(); //start money timer
    }

    //used when user sells animals or crops
    public void addMoney(int moneyAdd)
    {
        currentMoney += moneyAdd; //add money to users total
                                  //display total money to user
    }

    //used when user buys animals/crops/buildings
    public bool subtractMoney(int moneySub)
    {
        if (currentMoney - moneySub < 0)
        {
            //display message stating that user does not have enough money
            Debug.Log("Not enough money available to purchase that!");
            return false;
        }
        else
        {
            currentMoney -= moneySub; //subtract money from users total

            //display total money to user

            return true;
        }
    }

    //adds money to users total every 10min
    public void moneyTimer()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            //currentMoney += 100;
            //time = 600f;
            currentMoney++;
            time = 30f;
        }
    }
}
