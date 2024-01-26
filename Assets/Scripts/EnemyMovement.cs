using Unity.Collections;
using Unity.VisualScripting.ReorderableList;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [SerializeField]
    private float _minX, _maxX, _speed;
    // Used to track in which direction the object is moving
    private bool _movingRight = true;

    void Update()
    {
         // Check if the object has passed the left or right x-coordinate and flip the bool value accordingly.
        _movingRight = transform.position.x >= _maxX ? false : transform.position.x <= _minX ? true : _movingRight;
        // Move the object to left or right based on the bool value
        transform.Translate((_movingRight ? Vector2.right : Vector2.left) * _speed * Time.deltaTime);
       
    }
}
