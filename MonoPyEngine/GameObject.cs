public class GameObject
{
    // Called once when object is added to engine
    public virtual void Start() { }

    // Called every frame
    public virtual void Update(float dt) { }

    // Called at fixed intervals (physics)
    public virtual void FixedUpdate(float dt) { }
}