using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer {
[RequireComponent(typeof(InputReader), typeof(Mover))]
public class PlayerController : MonoBehaviour
{
    private InputReader _inputReader = null;
    private Mover _mover = null;

    private void Awake()
    {
        _inputReader = GetComponent<InputReader>();
        _mover = GetComponent<Mover>(); // Invoke the GetComponent method
    }

    // Update is called once per frame
    void Update()
    {
        bool JumpInput = _inputReader.JumpInput;
        _mover.Jump(JumpInput);

        Vector2 movement = _inputReader.Movement;
        _mover.Move(movement);
    }
}
}