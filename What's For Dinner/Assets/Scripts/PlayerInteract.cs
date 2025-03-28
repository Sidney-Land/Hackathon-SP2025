using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public CircleCollider2D playerInteractRadius;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            playerInteractRadius.enabled = true;
        }
        else
        {
            playerInteractRadius.enabled = false;
        }
    }
}
