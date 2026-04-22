using System;
using MonoPy;


#pragma warning disable CS0114

namespace MonoPy;
public class Player : MonoPy
{
    // Called when the script instance is being loaded (before Start)
    private void Awake()
    {
        Debug.Log("Player awakened");
    }

    // Called when the object becomes enabled and active
    private void OnEnable()
    {
        Debug.Log("Player enabled");
    }

    // Runs once when the object starts
    private void Start()
    {
        Debug.Log("Player started");
    }

    // Runs every frame
    private void Update()
    {
        // Check for input
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W key is pressed");
        } else if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S key is pressed");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed this frame");
        }


    }

    // Runs every frame after Update
    private void LateUpdate()
    {
        // Camera follow logic would go here
    }

    // Runs on fixed timestep
    private void FixedUpdate()
    {
        // Debug.Log("FixedUpdate: " + dt + ", FixedTime: " + Time.fixedTime);
    }

    // Called when the object becomes disabled
    private void OnDisable()
    {
        Debug.Log("Player disabled");
    }

    // Called when the script is being destroyed
    private void OnDestroy()
    {
        Debug.Log("Player destroyed");
    }
}