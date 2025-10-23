using UnityEngine;

public class Obstacles : MonoBehaviour
{
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.Sleep();
    }

    // Update is called once per frame
    void Update()
    {

    }
}