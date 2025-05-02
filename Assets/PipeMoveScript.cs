using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;  // Speed at which the pipe moves
    public float deadZone = -45;  // Position at which the pipe will be destroyed

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the pipe to the left
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        // If the pipe's x position goes below the dead zone, destroy it
        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Dihapus");
            Destroy(gameObject);
        }
    }
}
