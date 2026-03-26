using UnityEngine;

public class Circle : MonoBehaviour
{
    public float rotationSpeed;
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        //transform.Translate(0,0, -rotationSpeed * Time.deltaTime);
    }
}
