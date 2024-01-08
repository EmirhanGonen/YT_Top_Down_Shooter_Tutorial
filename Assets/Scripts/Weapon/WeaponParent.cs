using UnityEngine;

public class WeaponParent : MonoBehaviour
{
    [SerializeField] private Transform _leftHandPosition = null, _rightHandPosition = null;
    [SerializeField] private SpriteRenderer _weaponRenderer = null;
    [SerializeField] private Transform _bulletOutPosition = null;

    private Vector3 _outRightPosition = Vector3.zero;
    private Vector3 _outLeftPosition = Vector3.zero;

    public bool WeaponFaceRight => _weaponRenderer.flipX;

    private void Awake() {
        _outRightPosition = _bulletOutPosition.localPosition;
        _outLeftPosition = new Vector3(-_bulletOutPosition.localPosition.x, _bulletOutPosition.localPosition.y, _bulletOutPosition.localPosition.z);
    }

    private void Update() {
        Vector2 Direction = (GetMousePosition() - (Vector2)transform.root.position).normalized;

        transform.right = Mathf.Sign(Direction.x).Equals(-1.00f) ? -Direction : Direction;
        transform.localPosition = Mathf.Sign(Direction.x).Equals(-1.00f) ? _rightHandPosition.localPosition : _leftHandPosition.localPosition;
        _weaponRenderer.flipX = Mathf.Sign(Direction.x).Equals(-1.00f);

        Vector3 NewOutLocalPos = new Vector3(Mathf.Sign(Direction.x).Equals(-1.00f) ? _outLeftPosition.x : _outRightPosition.x,_bulletOutPosition.localPosition.y,_bulletOutPosition.localPosition.z);
        _bulletOutPosition.localPosition = NewOutLocalPos;
    }
    private Vector2 GetMousePosition() {
        Vector2 MousePos = Input.mousePosition;

        return Camera.main.ScreenToWorldPoint(MousePos);
    }
}