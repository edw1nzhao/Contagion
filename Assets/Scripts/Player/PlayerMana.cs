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
      
        // Set the initial health of the player.
        currMana = startMana;
        currMaxMana = startMana;
        setManaSlider(currMaxMana);
    }

    void Update() {

        if (currTime > second) {
            
            if (GM.mgr_element.LightOn()) {
                setManaSlider(GM.mgr_spells.castSpell(Elements.Light, currMana));
            }

            if (GM.mgr_element.DarkOn()) {
                setManaSlider(GM.mgr_spells.castSpell(Elements.Dark, currMana));
            }

            currTime = 0;
        } else {
            currTime += Time.deltaTime;
        }



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