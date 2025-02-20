using UnityEngine;


public class PlayerController : MonoBehaviour
{
    UnityEngine.Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    [SerializeField] float torqueAmount = 1f;
    [SerializeField ] float boostSpeed = 30f;
    [SerializeField ] float baseSpeed = 20f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d  = GetComponent<Rigidbody2D>();
        surfaceEffector2D = Object.FindFirstObjectByType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
       RotatePlayer();
       RespondToBoost();
    }

    private void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }

    void RotatePlayer()
    { if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount);
        }}
}
