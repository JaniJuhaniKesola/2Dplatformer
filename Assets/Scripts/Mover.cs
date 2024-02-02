using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer
{
public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    public void Move(Vector2 direction)
    {
        Vector2 position = transform.position;
        position += new Vector2(direction.x, direction.y) * Time.deltaTime;
        transform.position = position;
    }
    public void Jump(bool Jump)
    {
        if (Jump == true) {
        Debug.Log("Jump!");
        }
    }
}
}