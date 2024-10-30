using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform sun; // Reference to the Sun object in the scene
    public float orbitSpeed = 10f; // Speed of the orbit around the Sun
    public float selfRotationSpeed = 5f; // Speed of the planet's self-rotation

    void Update()
    {
        // Make the planet orbit around the Sun
        transform.RotateAround(sun.position, Vector3.up, orbitSpeed * Time.deltaTime);

        // Make the planet rotate around its own axis
        transform.Rotate(Vector3.up * selfRotationSpeed * Time.deltaTime);
    }
}
