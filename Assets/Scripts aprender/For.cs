using UnityEngine;

public class For : MonoBehaviour
{
    public string[] Nombres;
    public int nombresInt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i < 5; i++) //true
        {
            nombresInt = Random.Range(0, Nombres.Length);
            Debug.Log(Nombres[nombresInt]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
