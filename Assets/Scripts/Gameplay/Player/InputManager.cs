using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInputs playerInput;

    private void Awake()
    { 
        playerInput = new PlayerInputs();
        
    }

    void Update()
    {
        
    }
}
