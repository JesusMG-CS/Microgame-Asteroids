using UnityEngine;

public class Jugador : MonoBehaviour
{

    public float thrustforce = 5f;
    public float rotationspeed = 10f;
    private Rigidbody _rigid;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
