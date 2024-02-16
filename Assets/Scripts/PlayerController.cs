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
			isGrounded = Physics2D.OverlapCircle(_groundCheck.position + new Vector3(0f, 0.1f, 0f), 0.2f, _groundLayer);
			Move(_direction);
			if (_isJumping && isGrounded)
			{
				Jump();

			}
		}

        private void Jump()
        {
			_rb2D.AddForce(transform.up * _jumpForce, ForceMode2D.Impulse);
			_isJumping = false;
		}

		private void Move(Vector2 direction)
		{
			_rb2D.velocity = new Vector2(direction.x * _speed, _rb2D.velocity.y);
		}
	}
}