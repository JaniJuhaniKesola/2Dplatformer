using UnityEngine;

public class Fibonacci : MonoBehaviour
{
    int _count = 1;
    void Update()
    {
        if (_count < 1001)
        {
            Debug.Log("Current frame:" + _count);
            _count++;
        }
    }
}
