using System;
using UnityEngine;
using UnityEngine.UI;

public class Stove : Interactable
{
    public Button junkFood, healthyFood;
    public GameObject clock;
    public float cookingTime;

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
    }

    private void OnJunkFoodClick()
    {
        PlayerPrefs.SetFloat("HighScore", -1000);

        EnableButtons(false);
    }

    private void EnableButtons(bool buttonState)
    {
        junkFood.gameObject.SetActive(buttonState);
        healthyFood .gameObject.SetActive(buttonState);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    override public void Interact() 
    {
        Instantiate(clock);

        Tic clockTic = clock.GetComponent<Tic>();

        clockTic.maxTime = cookingTime;
        EnableButtons(true);
    }
}
