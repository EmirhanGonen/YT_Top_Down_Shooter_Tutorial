using UnityEngine;

public class WeaponParent : MonoBehaviour
{
    [SerializeField] private Transform _leftHandPosition = null, _rightHandPosition = null;
    [SerializeField] private SpriteRenderer _weaponRenderer = null;

    private void Update() {
        Vector2 Direction = (GetMousePosition() - (Vector2)transform.root.position).normalized;

        transform.right = Mathf.Sign(Direction.x).Equals(-1.00f) ? -Direction : Direction;
        transform.localPosition = Mathf.Sign(Direction.x).Equals(-1.00f) ? _rightHandPosition.localPosition : _leftHandPosition.localPosition;
        _weaponRenderer.flipX = Mathf.Sign(Direction.x).Equals(-1.00f);
    }
    private Vector2 GetMousePosition() {
        Vector2 MousePos = Input.mousePosition;

        return Camera.main.ScreenToWorldPoint(MousePos);
    }
}