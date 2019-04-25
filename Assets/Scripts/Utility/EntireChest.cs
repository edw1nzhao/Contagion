using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntireChest : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameObject Winner = GameObject.Find("WinnerScreen");
        if (gameObject.name == "ChestA" || gameObject.name == "PrizeA")
        {
            Winner.SetActive(false);
            Debug.Log("You beat it!!");
        }
        else if (gameObject.name == "ChestB" || gameObject.name == "PrizeB")
        {
            Debug.Log("Second Place.");
        }
        Debug.Log(Winner.activeSelf);

    }
}
