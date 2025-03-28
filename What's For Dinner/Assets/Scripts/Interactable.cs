using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.E))
        {
            Interact();
        }
        
    }

    abstract public void  Interact();
}
