using UnityEngine;

public class Direccionales : MonoBehaviour
{
    [Range(0 ,10), SerializeField, Tooltip("Velocidad lineal del coche")]
    public float speed = 10f;

    [Range(0 ,20), SerializeField, Tooltip("Velocidad de giro del coche")]
    public float turnspeed = 30f;
    
    public float horizontalInput, verticalInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        this.transform.Translate(speed * Time.deltaTime * Vector3.forward);
        transform.Rotate(turnspeed * Time.deltaTime * Vector3.up * horizontalInput);
    }
}
