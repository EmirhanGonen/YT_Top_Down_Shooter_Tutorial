using UnityEngine;

public class PlayerFlip : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer = null;

    private void Awake() {
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update() {
        Vector2 Direction = (GetMousePosition() - (Vector2)transform.position).normalized;
        _spriteRenderer.flipX = Mathf.Sign(Direction.x).Equals(-1.00f);
    }

    private Vector2 GetMousePosition() {
        Vector2 MousePos = Input.mousePosition;

        return Camera.main.ScreenToWorldPoint(MousePos);
    }
}