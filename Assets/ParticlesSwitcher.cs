using UnityEngine;

public class ParticlesSwitcher : MonoBehaviour {

    // Override inherited deprecated particleSystem variable.
    public new ParticleSystem particleSystem;

    // Y position below which the object is considered "grounded".
    public float groundedBelowY = .8f;

    // Checks if the object is on the ground.
    private bool IsGrounded
    {
        get
        {
            return transform.position.y < groundedBelowY;
        }
    }
    
    void Start () {
        // Find the Particle System in children if it wasn't explicitly set.
        if (particleSystem == null)
        {
            particleSystem = GetComponentInChildren<ParticleSystem>();
        }
	}
	
	void FixedUpdate () {
        // Get the emission component of the Particle System.
        ParticleSystem.EmissionModule emission = particleSystem.emission;

        // Enable particle emission if the object is grounded, disable otherwise.
        emission.enabled = IsGrounded;
	}
}
