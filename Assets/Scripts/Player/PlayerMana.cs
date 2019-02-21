using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerMana : MonoBehaviour {
    public int startMana = 100; 
    public int currMaxMana;
    public int currMana;   
    public Slider manaSlider; 

    public Text manaText;

    void Awake() {
        // Set the initial health of the player.
        currMana = startMana;
        currMaxMana = startMana;
        setManaSlider();
    }

    void Update() {
        if (Input.GetKeyDown("p")) {
            castSpell(Elements.Fire);
        } else if (Input.GetKeyDown("o")) {
            castSpell(Elements.Water);
        } else if (Input.GetKeyDown("i")) {
            castSpell(Elements.Earth);
        } else if (Input.GetKeyDown("u")) {
            castSpell(Elements.Wind);
        } else if (Input.GetKeyDown("l")) {
            castSpell(Elements.Dark);
        } else if (Input.GetKeyDown("k")) {
            castSpell(Elements.Light);
        } else if (Input.GetKeyDown("j")) {
            castSpell(Elements.Null);
        }
    }

    void castSpell(Elements e) {
        int cost = GM.mgr_element.getElementCost(e);

        if (currMana >= cost) {
            currMana -= cost;
            GM.mgr_element.DisplayElement(e);
        }
        
        setManaSlider();
    }

    void setManaSlider() {
        manaSlider.value = currMana;
        manaText.text = currMana + "/" + currMaxMana;
    }
}