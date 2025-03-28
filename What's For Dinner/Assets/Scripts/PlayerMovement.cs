using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    [SerializeField] private Rigidbody2D _Rigidbody2D;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(horizontal, vertical).normalized;
        _Rigidbody2D.linearVelocity = direction * speed;
    }
}
