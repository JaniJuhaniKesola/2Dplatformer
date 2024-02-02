using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer
{
public class InputReader : MonoBehaviour
{
    private Inputs _inputs = null;
    private Vector2 _movementInput = Vector2.zero;
    private bool _jumpInput = false;
    // Start is called before the first frame update

    public Vector2 Movement
    {
        get { return _movementInput; }
    }

    public bool JumpInput
    {
        get { return _jumpInput; }
    }
    private void Awake()
    {
        _inputs = new Inputs();
    }

    private void OnEnable()
    {
        _inputs.Game.Enable();
    }
    // Update is called once per frame
    void OnDisable()
    {
        _inputs.Game.Disable();
    }
    private void Update()
    {
        _movementInput = _inputs.Game.Move.ReadValue<Vector2>();
        _jumpInput = _inputs.Game.Jump.triggered;
    }
}
}
