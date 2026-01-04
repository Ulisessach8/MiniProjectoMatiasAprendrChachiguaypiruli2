
using System.Collections;

using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabEnemigoMatias;
    public Transform matias;
    public Transform[] puntos;
    public PoolEnemy poolEnemy;



   
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Spawning());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator Spawning()
    {
        
        int randomSitio = Random.Range(0, 4);
        sitios = (Sitios)randomSitio;
        GameObject enemy;
        enemy = poolEnemy.LookEnemyEnable();
        switch (sitios)
        {
            case Sitios.arriba:
               
                enemy.transform.position = new Vector3(Random.Range(puntos[0].position.x, puntos[1].position.x), puntos[1].position.y, 0);
                break;
            case Sitios.abajo:
                enemy.transform.position = new Vector3(Random.Range(puntos[3].position.x, puntos[2].position.x), puntos[2].position.y, 0);
                break;
            case Sitios.izquierda:
                enemy.transform.position = new Vector3(puntos[0].position.x, Random.Range( puntos[0].position.y, puntos[3].position.y), 0);
                break;
            case Sitios.derecha:
                enemy.transform.position = new Vector3(puntos[2].position.x, Random.Range(puntos[1].position.y, puntos[2].position.y), 0);
                break;
            default:
                enemy.transform.position = new Vector3(puntos[0].position.x, Random.Range(puntos[0].position.y, puntos[3].position.y), 0);
                break;
        }
        enemy.GetComponent<matiasenemigo>().SetUp(matias);
        enemy.SetActive(true);
        yield return new WaitForSeconds(3);
        StartCoroutine(Spawning());

    }
    public enum Sitios
    {
       arriba,
       abajo,
       izquierda,
       derecha

    }
    public Sitios sitios;
}
