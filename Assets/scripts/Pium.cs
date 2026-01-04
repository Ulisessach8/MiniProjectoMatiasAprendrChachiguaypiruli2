using System.Collections;
using UnityEngine;

public class Pium : MonoBehaviour
{
    public Transform puntoDisparo;
    public GameObject prefabBala;
    public Transform contenedorBalas;
    

     GameObject[] miniMatias = new GameObject[40];
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < miniMatias.Length; i++)
        {
            miniMatias[i] = Instantiate(prefabBala, puntoDisparo.position, Quaternion.identity);
            miniMatias[i].transform.parent = contenedorBalas;
            miniMatias[i].SetActive(false);
            
        }
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {

            Vector3 mousePosition = Input.mousePosition;

            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            Vector3 direction = (mousePosition - transform.position).normalized;

            GameObject bullet;

            bullet = LookMatias();

            bullet.SetActive(true);

            bullet.transform.position = puntoDisparo.position;

            bullet.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;

            bullet.GetComponent<Rigidbody2D>().linearVelocity = direction * 100;
        }
        
    }
    
    public GameObject LookMatias()
    {
        for (int i = 0; i < miniMatias.Length; i++)
        {
            if(miniMatias[i].activeSelf == false)
            {
                
                return miniMatias[i];
            }
            

        }
        return null;
    }
}

