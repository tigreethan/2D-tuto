using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction MoveAction;
    // Start is called before the first frame update
    void Start()
    {
     MoveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = 0.0f;
        if (MoveAction.IsPressed())
        {

            horizontal = -0.01f;

        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {

            horizontal = + 0.01f;
            
        }
        Debug.Log(horizontal);
        float vertical = 0.0f;
        if (Keyboard.current.downArrowKey.isPressed)
        {

            vertical = -0.01f;

        }
        else if (Keyboard.current.upArrowKey.isPressed)
        {

            vertical = + 0.01f;

        }
        Debug.Log(vertical);
        Vector2 position = transform.position;
        position.x = position.x + horizontal;
        position.y = position.y + vertical;
        transform.position = position;

    }
}
