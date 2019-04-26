using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
    private int startHealth = Globals.PLAYER_START_HP;
    private int currHealth;
    private int currMaxHealth;

    public Slider healthSlider;
    public Text healthText;

    float second = 1f;
    float currTime = 0.0f;

    void Awake() {
        currHealth = startHealth;
        currMaxHealth = startHealth;
        setHealthSlider(currMaxHealth);
    }

    void Update() {
        if (currTime > second) {

            currTime = 0;
        } else {
            currTime += Time.deltaTime;
        }
    }

    public int getHealth() {
        return this.currHealth;
    }

    public int getMaxHP() {
        return this.currMaxHealth;
    }
    public void addHealth(int amt){
        Debug.Log(currHealth);
        Debug.Log(amt);

        currHealth += amt;
        if (currHealth > 100){
            currHealth = 100;
        }

        setHealthSlider(currHealth);
    }

    public void setHealthSlider(int h) {
        currHealth = h;
        healthSlider.value = h;
        healthText.text = currHealth + "/" + currMaxHealth;
    }
}