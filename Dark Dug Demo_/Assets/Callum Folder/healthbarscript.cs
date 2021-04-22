using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbarscript : MonoBehaviour
{
    private healthsystem healthbox;
    public Slider healthbar;
    public Text hptext;
    // Start is called before the first frame update
    void Start()
    {
        healthbox = FindObjectOfType<healthsystem>();
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.maxValue = healthbox.maxHealth;
        healthbar.value = healthbox.currentHealth;
        hptext.text = "HP:" + healthbox.currentHealth + "/" + healthbox.maxHealth;
    }
}
