using UnityEngine;

public class HorizontalRotation: MonoBehaviour
{
    public float rotationSpeed;
    public Transform target;
    void Update()
    {
        Vector3 horizontalTarget = target.position;
        horizontalTarget.y = transform.position.y;
        Quaternion current = transform.rotation;
        Quaternion direction = Quaternion.LookRotation(horizontalTarget - transform.position);
        transform.rotation = Quaternion.RotateTowards(current, direction, rotationSpeed * Time.deltaTime);
    }
}
