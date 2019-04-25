using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChestScript : MonoBehaviour
{
    static bool right = false;
    static bool left = false;
    public GameObject PrizeA;
    public GameObject PrizeB;
    private Animation myAnimationComponent;
    private void OnMouseEnter()
    {
        myAnimationComponent = GetComponent<Animation>();
        myAnimationComponent.Play("ChestOpen");
        Debug.Log("SWagggg");
        if (gameObject.name == "ChestCoverA")
        {
            PrizeA.gameObject.SetActive(true);
        }
        else
        {
            PrizeB.gameObject.SetActive(true);
        }
    }
    private void OnMouseDown()
    {
        myAnimationComponent = GetComponent<Animation>();
        myAnimationComponent.Play("ChestOpen");

        if (gameObject.name == "ChestCoverA")
        {
            Debug.Log("You beat it!!");
        }
        else
        {
            Debug.Log("Second Place.");
        }

        //if (gameObject.name == "ChestA")
        //{
        //    PrizeA.gameObject.SetActive(true);
        //    //if (left)
        //    //{ 
        //    //    SceneManager.LoadScene("Town");
        //    //}
        //    //right = true;
        //}
        //else
        //{
        //    PrizeB.gameObject.SetActive(true);
        //    //if (right)
        //    //{ 
        //    //    SceneManager.LoadScene("Town");
        //    //}
        //    //left = true;
        //}
    }
}
