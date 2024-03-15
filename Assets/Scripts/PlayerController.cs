using UnityEngine;

namespace Platformer
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerController : MonoBehaviour
    {
        [SerializeField]
        private float _speed, _jumpForce;

        private Rigidbody2D _rb2D;
        private InputReader _inputReader;

        private bool _isJumping = false;
        private Vector2 _direction = Vector2.zero;

        private bool isGrounded;
        private Transform _groundCheck;
        private LayerMask _groundLayer;

        // Variables for power-up
        private bool _isPoweredUp = false;
        private float _powerUpTimer = 0f;
        private const float _powerUpDuration = 5f;
        private const float _powerUpSpeedMultiplier = 1.5f;

        private void Awake()
        {
            _rb2D = GetComponent<Rigidbody2D>();
            _inputReader = GetComponent<InputReader>();
            _groundCheck = transform.Find("GroundCheck");
            _groundLayer = LayerMask.GetMask("Ground");
        }

        private void Update()
        {
            _direction = _inputReader.Movement;

            bool isJumping = _inputReader.JumpInput;
            if (!_isJumping && isJumping)
            {
                _isJumping = true;
            }
        }

        private void FixedUpdate()
        {
            // Check if the player is grounded
            isGrounded = Physics2D.OverlapCircle(_groundCheck.position + new Vector3(0f, 0.1f, 0f), 0.2f, _groundLayer);

            // Move the player
            Move(_direction);

            // Check if the player is jumping and grounded
            if (_isJumping && isGrounded)
            {
                Jump();
            }

            // Update power-up timer
            if (_isPoweredUp)
            {
                _powerUpTimer -= Time.deltaTime;
                if (_powerUpTimer <= 0)
                {
                    // Power-up duration ended, revert speed back to normal
                    _isPoweredUp = false;
                    _speed /= _powerUpSpeedMultiplier;
                }
            }
        }

        private void Jump()
        {
            _rb2D.AddForce(transform.up * _jumpForce, ForceMode2D.Impulse);
            _isJumping = false;
        }

        private void Move(Vector2 direction)
        {
            // Apply speed boost if powered up
            if (_isPoweredUp)
            {
                _rb2D.velocity = new Vector2(direction.x * _speed * _powerUpSpeedMultiplier, _rb2D.velocity.y);
            }
            else
            {
                _rb2D.velocity = new Vector2(direction.x * _speed, _rb2D.velocity.y);
            }
        }

        // OnTriggerEnter2D is called when the Collider2D other enters the trigger (2D physics only)
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("PowerUp"))
            {
                // Apply speed boost
                _isPoweredUp = true;
                _powerUpTimer = _powerUpDuration;
                _speed *= _powerUpSpeedMultiplier;

                // Disable the power-up object
                other.gameObject.SetActive(false);
            }
        }
    }
}
