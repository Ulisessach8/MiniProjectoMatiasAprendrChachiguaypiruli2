using UnityEngine;

public class Pares : MonoBehaviour
{
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i <= 10; i++)
        {
            if(i % 2 == 0)
            {
                Debug.Log(i);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
