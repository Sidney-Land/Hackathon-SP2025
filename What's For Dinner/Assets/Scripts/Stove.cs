using UnityEngine;

public class Stove : Interactable
{
    public GameObject clock;
    public float cookingTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
    }
}
