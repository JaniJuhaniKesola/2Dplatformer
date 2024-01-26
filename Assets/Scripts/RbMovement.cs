using System.Threading;
using UnityEngine;

public class RbMovement : MonoBehaviour
{
    [SerializeField]
    private float speed, minY;
    private Rigidbody2D _rb2D;
    private bool _movingDown = true;
    private Vector2 _originalPosition;

    private void Awake()
    {
        _rb2D = GetComponent<Rigidbody2D>();
        _originalPosition = _rb2D.position;
    }

private void FixedUpdate()
{
    // Check if rb y position has passed either the original or the min y coordinate and flip the bool value accordingly.
    _movingDown = _rb2D.position.y <= minY ? false : _rb2D.position.y >= _originalPosition.y ? true : _movingDown;
    // Move object down or up based on the bool value
    _rb2D.MovePosition(_rb2D.position + (_movingDown ? Vector2.down : Vector2.up) * speed * Time.fixedDeltaTime);
}
}
