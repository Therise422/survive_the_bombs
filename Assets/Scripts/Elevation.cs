using UnityEngine;

public class Elevation : MonoBehaviour
{
    public float rotationSpeed;
    public Transform target;
    void Update()
    {
        Vector3 horizontalTarget = target.position;
        horizontalTarget.y = transform.position.y;
        Vector3 horizontalDirection = horizontalTarget - transform.position;
        float angle = Vector3.Angle(horizontalDirection, target.position - transform.position);
        Quaternion targetRotation = Quaternion.Euler(-angle, 0, 0);
        transform.localRotation = Quaternion.RotateTowards(transform.localRotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}
