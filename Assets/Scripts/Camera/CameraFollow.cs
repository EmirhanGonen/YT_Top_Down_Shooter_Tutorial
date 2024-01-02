using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target = null;
    [SerializeField] private float _followSpeed = 0.00f;
    [SerializeField] private Vector3 _offset = Vector3.zero;

    private void FixedUpdate() {
        if(_target is null) 
            return;

        transform.position = Vector3.Lerp(transform.position, _target.position + _offset, _followSpeed);
    }
}