using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Transform _bulletOutPosition = null;
    [SerializeField] private Bullet _bulletPrefab = null;

    private WeaponParent _weaponParent = null;

    private void Awake() {
        _weaponParent = transform.parent.GetComponent<WeaponParent>();
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Bullet spawnedBullet = Instantiate(_bulletPrefab, _bulletOutPosition.position, Quaternion.identity);
            spawnedBullet.Execute(_bulletOutPosition.right * (_weaponParent.WeaponFaceRight ? -1.00f : 1.00f));
        }
    }
}