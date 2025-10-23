using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;

        
    }
    private void OnCollisionEnter(Collision collision)
    {
        print("Collision" + collision.gameObject.name);
    }
}
