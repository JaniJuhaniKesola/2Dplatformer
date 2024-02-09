using UnityEngine;

namespace Platformer
{  
    public class Mover : MonoBehaviour
    {
        [SerializeField]
        private float _speed, _jumpForce;
        private Rigidbody2D rb2d;

        private void Awake()
        {
            rb2d = GetComponent<Rigidbody2D>();
        }

        public void Move(Vector2 direction)
        {
            rb2d.velocity = direction * _speed;
        }

        public void Jump(bool Jump)
        {
            if (Jump) {
                rb2d.velocity = new Vector2(rb2d.velocity.x, _jumpForce);
            }
        }
    }
}