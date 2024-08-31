using System;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    [SerializeField] private float speed = 2.5f;
    [SerializeField] private float deactivateTimer = 6f;
    
    private bool hasScored = false;

    void Start()
    {
        Invoke(nameof(DeactivePipe), deactivateTimer);
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 temp = transform.position;
        temp.x -= speed * Time.deltaTime;

        transform.position = temp;
        
        if (!hasScored && temp.x < -8.4f)
        {
            Debug.Log("Scored");
            Score.scoreValue += 1;
            hasScored = true;
        }
    }
    
    void DeactivePipe()
    {
        gameObject.SetActive(false);
    }

}
