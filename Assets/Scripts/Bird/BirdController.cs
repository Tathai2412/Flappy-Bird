using System;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField] private float velocity;
    [SerializeField] private float rollSpeed;
    public GameObject spawner;
    public GameObject startScreen;
    public GameObject score;
    
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        Time.timeScale = 1;
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 rot = transform.rotation.eulerAngles;
        if (rb.velocity.y < 0)
        {
            rot.z -= rollSpeed * Time.deltaTime;
            float deltaAngle = Mathf.DeltaAngle(0, rot.z);
            
            if (deltaAngle <= -90)
            {
                rot.z = 270f;
            }
        }
        
        transform.rotation = UnityEngine.Quaternion.Euler(rot);
        
        if (Input.touches.Length > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                rot.z = 25;
                transform.rotation = UnityEngine.Quaternion.Euler(rot);
        
                rb.velocity = Vector2.up * velocity;
                rb.gravityScale = 1.5f;
                spawner.SetActive(true);
                score.SetActive(true);
                startScreen.SetActive(false);
            }
        }
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag.Equals("Ground")) 
        {
            Time.timeScale = 0;
        }
    }
}
