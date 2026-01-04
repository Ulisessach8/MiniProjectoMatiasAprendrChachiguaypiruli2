using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Bull : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        StartCoroutine(Recicle());
    }
    public IEnumerator Recicle()
    {
        yield return new WaitForSeconds(5);
        gameObject.SetActive(false);// :(
    }

}
