public class Player : GameObject
{
    // Called when the script instance is being loaded (before Start)
    public void Awake()
    {
        Debug.Log("Player awakened");
    }

    // Called when the object becomes enabled and active
    public void OnEnable()
    {
        Debug.Log("Player enabled");
    }

    // Runs once when the object starts
    public void Start()
    {
        Debug.Log("Player started");
    }

    // Runs every frame
    public void Update(float dt)
    {
        // Check for input
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W key is pressed");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed this frame");
        }

        // Log time info
        Debug.Log("Time: " + Time.time + ", DeltaTime: " + Time.deltaTime);
    }

    // Runs every frame after Update
    public void LateUpdate(float dt)
    {
        // Camera follow logic would go here
    }

    // Runs on fixed timestep
    public void FixedUpdate(float dt)
    {
        Debug.Log("FixedUpdate: " + dt + ", FixedTime: " + Time.fixedTime);
    }

    // Called when the object becomes disabled
    public override void OnDisable()
    {
        Debug.Log("Player disabled");
    }

    // Called when the script is being destroyed
    public override void OnDestroy()
    {
        Debug.Log("Player destroyed");
    }
}