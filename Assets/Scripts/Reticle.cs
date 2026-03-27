using UnityEngine;
using UnityEngine.InputSystem;

public class Reticle : MonoBehaviour
{
    public float depth = 5f;
    public LayerMask targetMask;
    public Transform target;
    [SerializeField] private Camera screenCamera;

    void Update()
    {
        Vector3 screenPoint = screenCamera.WorldToScreenPoint(transform.position);
        Ray ray = screenCamera.ScreenPointToRay(screenPoint);
        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, targetMask))
        {
            target.position = hit.point;
        }
    }


    void OnLook(InputValue input)
    {
        Vector3 screenPosition = input.Get<Vector2>();
        screenPosition.z = depth;
        transform.position = screenCamera.ScreenToWorldPoint(screenPosition);
    }

}
