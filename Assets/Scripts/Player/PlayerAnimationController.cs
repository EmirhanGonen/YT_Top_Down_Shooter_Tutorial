using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    private Animator _animator = null;

    private void Awake() {
        _animator = GetComponentInChildren<Animator>();
    }

    private void Update() {
        float Horizontal = Input.GetAxisRaw("Horizontal");
        float Vertical = Input.GetAxisRaw("Vertical");

        _animator.SetBool("IsMoving", Horizontal != 0.00f || Vertical != 0.00f);
    }
}