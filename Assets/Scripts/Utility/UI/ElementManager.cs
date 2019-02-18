using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElementManager : MonoBehaviour
{
    public Image eFire;
    public Image eEarth;
    public Image eWater;
    public Image eWind;
    public Image eDark;
    public Image eLight;
    public Image eNull;

    float time;
    public float displayTime = 0.2f;

    bool displayIcon;
    void Start() {
        GM.mgr_element = this;
    }

     void Update() {
        if  (displayIcon) {
            time += Time.deltaTime;
            if (time >= displayTime) {
                IconsOff();

                displayIcon = false;
                time = 0;
            }
        }
    }
    public void DisplayElement(Elements e) {
        if (displayIcon) IconsOff();

        switch (e) {
            case Elements.Fire:
                eFire.gameObject.SetActive(true);
                break;
            case Elements.Earth:
                break;
            case Elements.Water:
                break;
            case Elements.Wind:
                eWind.gameObject.SetActive(true);
                break;
            case Elements.Dark:
                break;
            case Elements.Light:
                break;
            case Elements.Null:
                break;
        }

        displayIcon = true;     
    }

    void IconsOff() {
        eFire.gameObject.SetActive(false);
        //eWater.gameObject.SetActive(false);
        //eEarth.gameObject.SetActive(false);
        eWind.gameObject.SetActive(false);
        //eDark.gameObject.SetActive(false);
        //eLight.gameObject.SetActive(false);
        //eNull.gameObject.SetActive(false);
    }
}
