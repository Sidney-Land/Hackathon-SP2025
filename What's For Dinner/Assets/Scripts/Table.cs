using UnityEngine;
using UnityEngine.SceneManagement;

public class Table : Interactable
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Interact()
    {

        SceneManager.LoadScene("Game Over");
    }
}
