using UnityEngine;

public class Jugador : MonoBehaviour
{

    public float thrustforce = 100f;
    public float rotationspeed = 120f;
    public GameObject gun, bulletPrefab;
    private Rigidbody _rigid;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float rotation = Input.GetAxis("Horizontal") * Time.deltaTime;
        float thrust_ = Input.GetAxis("Thrust") * Time.deltaTime;
        Vector3 thrustDirection = transform.right;

        _rigid.AddForce(thrustDirection * thrust_* thrustforce);
        transform.Rotate(Vector3.forward, -rotation * rotationspeed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(bulletPrefab, gun.transform.position, Quaternion.identity);
            Bullet balaScript = bullet.GetComponent<Bullet>();
            balaScript.targetVector = transform.right;
        }

    }
}
