using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        // For coins
        if(other.transform.tag == "Coin")
        {
            other.gameObject.SetActive(false);
        }
        else if(other.transform.tag == "Switch") // for switch
        {
            other.transform.GetChild(1).gameObject.SetActive(false);
            other.transform.GetComponent<BoxCollider2D>().enabled = false;
            Transform door = GameObject.FindGameObjectWithTag("Door").transform;
            door.GetChild(0).gameObject.SetActive(false);
            door.GetChild(1).gameObject.SetActive(false);
        }
        else if(other.transform.tag == "Door") // Level ending
        {
            Debug.LogError("Level Finished");
        }
        else if(other.transform.tag == "Obstacle")
        {
            Debug.LogError("You've just died");
        }
    }
}
