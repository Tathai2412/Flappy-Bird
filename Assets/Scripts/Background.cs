using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Background : MonoBehaviour
{
    
    [SerializeField] private float speed = 2.5f;
    [SerializeField] private float minPos, maxPos;

    void Update()
    {
        Scroll();
    }

    void Scroll()
    {
        Vector3 temp = transform.position;
        temp.x += speed * Time.deltaTime;

        if (temp.x >= maxPos)
        {
            temp.x = minPos;
            temp.x += speed * Time.deltaTime;
        }

        transform.position = temp;
    }
}
