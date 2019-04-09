using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalCornManager : MonoBehaviour
{
    public static List<string> manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = new List<string>();
        Debug.Log("manager list created!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
