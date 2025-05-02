using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;
    public float horizontalOffset = 5; // Tambahkan variabel untuk jarak horizontal

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }

    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        // Instantiate pipa dengan offset horizontal
        Instantiate(pipe, new Vector3(transform.position.x + horizontalOffset, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);

        // Setelah spawn, geser posisi spawner ke kanan untuk pipa berikutnya
        transform.position = new Vector3(transform.position.x + horizontalOffset, transform.position.y, transform.position.z);
    }
}