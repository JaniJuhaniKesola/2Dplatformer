using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    private int _a = 0, _b = 1;

    void Start()
    {
        Debug.Log("Hello World");
    }

    void Update()
    {    
        if (_a <= 1000)
        {
            Debug.Log(_a);
            int temp = _a;
            _a = _b;
            _b = temp + _b;
        }
    }
}
