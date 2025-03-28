using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public SpriteRenderer spriteRenderer;

    [SerializeField] private Rigidbody2D _Rigidbody2D;
    [SerializeField] private Animator _Animator;
    private int _Animaton_Run_Parameter;

    private void Awake()
    {
        _Animaton_Run_Parameter = Animator.StringToHash("run");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(horizontal, vertical).normalized;
        _Rigidbody2D.linearVelocity = direction * speed;
        UpdateAnimator(direction);
    }

    private void UpdateAnimator(Vector2 direction)
    {
        if (direction.x != 0)
            spriteRenderer.flipX = direction.x > 0 ? false : true;
        if (direction == Vector2.zero)
            _Animator.SetBool(_Animaton_Run_Parameter, false);
        else
            _Animator.SetBool(_Animaton_Run_Parameter, true);
    }

}
