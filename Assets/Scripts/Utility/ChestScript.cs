using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChestScript : MonoBehaviour
{
    static bool right = false;
    static bool left = false;
    private Animation myAnimationComponent;
    private void OnMouseEnter()
    {
        myAnimationComponent = GetComponent<Animation>();
        myAnimationComponent.Play("ChestOpen");
        Debug.Log("SWagggg");
    }

    private void OnMouseDown()
    {
        myAnimationComponent = GetComponent<Animation>();
        myAnimationComponent.Play("ChestOpen");

        if (gameObject.name == "ChestA")
        {
            if (left)
            {
                SceneManager.LoadScene("Town");
            }
            right = true;
        }
        else
        {
            if (right)
            {
                SceneManager.LoadScene("Town");
            }
            left = true;
        }

    }


    //private void OnMouseExit()
    //{
    //    myAnimationComponent = GetComponent<Animation>();
    //    myAnimationComponent.Play("ChestClose");
    //    Debug.Log("SWagggg");
    //}
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
