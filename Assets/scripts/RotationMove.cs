using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotationMove : MonoBehaviour
{
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
        Vector3 mousePosition = Input.mousePosition;
        
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector3 direction = mousePosition - transform.position;

        float angle = Vector2.SignedAngle(Vector2.up, direction);

        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
