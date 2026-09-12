using UnityEngine;
using UnityEngine.Windows;
using UnityEngine.InputSystem;


public class PlayerControlScript : MonoBehaviour
{

    public static Vector2 movement;
    //Establishes the movmement variable with which the direction of the player is in
    private PlayerInput playerInput;
    //Establishes the player input component in the input manager

    public

    private InputAction moveAction;
    //Establishes an action that the player can take
    void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        //Gets the player input component
        moveAction = playerInput.actions["Move"];
        //The move action variable is now set to the move command in the player inputs
  
    }

    // Update is called once per frame
    void Update()
    {
        movement = moveAction.ReadValue<Vector2>();
        //The movement vatiable is now set to read the vector 2 of the player movement script under the same name. Correct me if i'm wrong.

    }
}

