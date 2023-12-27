using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 0.00f;

    private Rigidbody2D _rigidbody2D = null;
    private float _horizontalInput = 0.00f;
    private float _verticalInput = 0.00f;

    private void Awake() {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        _horizontalInput = Input.GetAxisRaw("Horizontal");
        _verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate() {
        _rigidbody2D.velocity = new Vector2(_horizontalInput, _verticalInput).normalized * _moveSpeed;
    }
}