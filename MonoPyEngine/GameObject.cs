public class GameObject
{
    // Called when the script instance is being loaded (before Start)
    public virtual void Awake() { }

    // Called when the object becomes enabled and active
    public virtual void OnEnable() { }

    // Called once when object is added to engine
    public virtual void Start() { }

    // Called every frame
    public virtual void Update(float dt) { }

    // Called every frame after Update
    public virtual void LateUpdate(float dt) { }

    // Called at fixed intervals (physics)
    public virtual void FixedUpdate(float dt) { }

    // Called when the object becomes disabled
    public virtual void OnDisable() { }

    // Called when the script is being destroyed
    public virtual void OnDestroy() { }
}