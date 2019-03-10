using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
    public int startHealth = 100;
    public int currHealth;
    public int currMaxHealth;

    public Slider healthSlider;
    public Text healthText;


    void Awake() {
        currHealth = 60;
        currMaxHealth = startHealth;
        setHealthSlider();
    }

    void Update() {

    }

    public void addHealth(int amt){
        Debug.Log(currHealth);
        Debug.Log(amt);
        currHealth += amt;
        if(currHealth > 100){
            currHealth = 100;
        }
        Debug.Log(currHealth);
        healthSlider.value = currHealth;
        healthText.text = currHealth + "/" + currMaxHealth;
    }

    public void setHealthSlider() {
        healthSlider.value = currHealth;
        healthText.text = currHealth + "/" + currMaxHealth;
    }
}