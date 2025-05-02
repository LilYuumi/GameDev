using UnityEngine;

public class BirdScript : MonoBehaviour
{
    
    public Rigidbody2D myRigidbody;
    public float flapStrength;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // You can initialize things here if needed (e.g., get the Rigidbody2D component)
        if (myRigidbody == null)
        {
            myRigidbody = GetComponent<Rigidbody2D>();  // Automatically fetch the Rigidbody2D attached to the GameObject
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
              myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }


    }
}
