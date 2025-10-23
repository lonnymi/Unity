using UnityEngine;
using UnityEngine.InputSystem;

public class SlingShot : MonoBehaviour
{
    public GameObject canonBall;
    public InputActionReference createCannonAction;
    public float maxForce;
    public float minForce;
    public float throwForce;
    GameObject currentCannonBall;
    Vector3 throwDir;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (createCannonAction.action.WasPerformedThisFrame())
        {
            Vector3 temp = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z);
            print(Input.mousePosition + " Before Conversion");
            Vector3 spawnPos = Camera.main.ScreenToWorldPoint(temp);
            print(Input.mousePosition + " After Conversion");
            currentCannonBall = Instantiate(canonBall, spawnPos, Quaternion.identity);

            currentCannonBall.GetComponent<Rigidbody>().Sleep();
        }
        if (createCannonAction.action.IsPressed())
        {
            Vector3 temp = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z);
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(temp);
            throwDir = currentCannonBall.transform.position - mousePos;
        }
        if (createCannonAction.action.WasReleasedThisFrame())
        {
            float lenght = Mathf.Clamp(throwDir.magnitude, minForce, maxForce);
            currentCannonBall.GetComponent<Rigidbody>().AddForce(throwDir.normalized * lenght * throwForce);
        }
    }
}   