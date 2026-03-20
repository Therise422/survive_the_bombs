using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject projectile;
    public Transform bulletOrigin;
    public Transform target;
    public float fireForce;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnFire() 
    {
        Vector3 direction = target.position - bulletOrigin.position;
        direction = direction.normalized;
        GameObject clone = Instantiate(projectile,bulletOrigin.position, Quaternion.identity);

        clone.GetComponent<Rigidbody>().AddForce(direction * fireForce, ForceMode.Impulse);
    }
}
