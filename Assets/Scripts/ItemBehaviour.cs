﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemBehaviour : MonoBehaviour
{

    public string itemName;
    public string itemID;
    public float weight;
    public Item itemConfig;
    private Item itemRuntime;

   
    void Start()
    {
        itemRuntime = Instantiate(itemConfig);
    }
    void Update()
    {
        //int last = GetComponent<BackpackBehaviour>().contents.Count - 1;
        //Item item = GetComponent<BackpackBehaviour>().contents[last];
        //if (GetComponent<BackpackBehaviour>().drop == true)
        //{
        //    if(item.name == "Health Potion")
        //    {
                
        //    }
        //}
            
    }

    void OnTriggerEnter(Collider other)
    {
        int count = other.gameObject.GetComponent<BackpackBehaviour>().contents.Count;
        if (other.gameObject.CompareTag("Player"))
        {
            if (other.gameObject.GetComponent<BackpackBehaviour>())
            {
                other.gameObject.GetComponent<BackpackBehaviour>().AddItem(itemRuntime);
                if (itemRuntime == other.gameObject.GetComponent<BackpackBehaviour>().contents[count])
                {
                    Destroy(gameObject);
                    Debug.Log(itemConfig.name + " added");
                }
            }
        }
    }
}

