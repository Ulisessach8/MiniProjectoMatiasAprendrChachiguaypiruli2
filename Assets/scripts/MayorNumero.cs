using Unity.VisualScripting;
using UnityEngine;

public class MayorNumero : MonoBehaviour
{
    public int[] numeros = { 100, -1, 35, 1000, -90, 3000, 50, -100 };
    public int numeroMayor;
    int numeroMayorLocal;
    int posArrayNumeroMayor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i < numeros.Length; i++)
        {

            numeroMayorLocal = numeros[i];

            if(numeroMayorLocal > numeroMayor)
            {
                numeroMayor = numeroMayorLocal;
                posArrayNumeroMayor = i;
                
            }
           
        }
        Debug.Log("El Numero mayor de la array es " + numeroMayor + " i su posicion en el array es " + posArrayNumeroMayor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
