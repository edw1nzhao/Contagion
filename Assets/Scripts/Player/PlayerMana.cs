using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerMana : MonoBehaviour {
    public int startMana = 100; 
    public int currMaxMana;
    public int currMana;   
    public Slider manaSlider; 

    public Text manaText;

    float second = 1f;
    float currTime = 0.0f;

    void Awake() {
        currMana = startMana;
        currMaxMana = startMana;
        setManaSlider(currMaxMana);
    }

    void Update() {
        if (currTime > second) {

            currTime = 0;
        } else {
            currTime += Time.deltaTime;
        }
    }

    public void addMana(int amt) {
        Debug.Log(currMana);
        Debug.Log(amt);

        currMana += amt;
        if (currMana > 100) {
            currMana = 100;
        }

        setManaSlider(currMana);
    }

    public void setManaSlider(int m) {
        currMana = m;
        manaSlider.value = m;
        manaText.text = currMana + "/" + currMaxMana;
    }

    public int getMana() {
        return currMana;
    }
}