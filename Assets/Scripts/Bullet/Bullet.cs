using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _executeSpeed = 0.00f;
    private Rigidbody2D _rigidbody2D = null;

    public void Execute(Vector2 Direction) {
        Destroy(gameObject, 2.00f);

        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.velocity = Direction.normalized * _executeSpeed;
    }
}