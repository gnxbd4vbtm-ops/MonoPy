public class Player : GameObject
{
    // Runs once when the object starts
    public override void Start()
    {
        Debug.Log("Player started");
    }

    // Runs every frame
    public override void Update(float dt)
    {
        Debug.Log("Update: " + dt);
    }

    // Runs on fixed timestep
    public override void FixedUpdate(float dt)
    {
        Debug.Log("FixedUpdate: " + dt);
    }
}