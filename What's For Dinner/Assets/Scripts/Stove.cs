using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Stove : Interactable
{
    public Button junkFood, healthyFood;
    public GameObject clock;
    public float cookingTime;

    public TextMeshProUGUI instructionText; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        junkFood.onClick.RemoveAllListeners();
        healthyFood.onClick.RemoveAllListeners();

        junkFood.onClick.AddListener(OnJunkFoodClick);
        healthyFood.onClick.AddListener(OnHealthyFoodClick);

        EnableButtons(false);
    }

    private void OnHealthyFoodClick()
    {
        PlayerPrefs.SetFloat("HighScore", 1000);

        EnableButtons(false);
        UpdateInstructions();
    }

    private void OnJunkFoodClick()
    {
        PlayerPrefs.SetFloat("HighScore", -1000);

        EnableButtons(false);
        UpdateInstructions();
    }

    private void EnableButtons(bool buttonState)
    {
        junkFood.gameObject.SetActive(buttonState);
        healthyFood .gameObject.SetActive(buttonState);
    }

    private void UpdateInstructions()
    {
        instructionText.text = "Now press \"E\" on the table to eat your food!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    override public void Interact() 
    {
        EnableButtons(true);
    }
}
