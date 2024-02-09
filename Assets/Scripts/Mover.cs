using UnityEngine;

namespace Platformer
{  
    public class Mover : MonoBehaviour
    {
        [SerializeField]
        private float _speed;
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
                Debug.Log("Jump!");
            }
        }
    }
}