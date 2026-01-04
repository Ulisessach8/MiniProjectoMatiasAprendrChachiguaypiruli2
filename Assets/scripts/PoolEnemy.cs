using UnityEngine;

public class PoolEnemy : MonoBehaviour
{
    public GameObject[] Enemies = new GameObject[10];
    public GameObject prefabEnemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        for (int i = 0; i < Enemies.Length; i++)
        {
            Enemies[i] = Instantiate(prefabEnemy, Vector3.zero, Quaternion.identity);
            prefabEnemy.SetActive(false);
        }
    }

   public GameObject LookEnemyEnable()
   {
        for(int i = 0;  i < Enemies.Length;i++)
        {
            if(Enemies[i].activeSelf == false)
            {
                return Enemies[i];
            }
        }
       return null;
   }
}
