using UnityEngine;

public class MyFavouriteGame : MonoBehaviour
{
    public string[] misJuegosFav = {"MatiasGame", "MatiasHorror", "MatiasJob", "MatiasYT", "Hoy se Estudia"};
    public int juegoDeHoy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HoyTengoGanasDe();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HoyTengoGanasDe()
    {
        juegoDeHoy = Random.Range(0, misJuegosFav.Length);

        Debug.Log( "Hoy quiero jugar a " + misJuegosFav[juegoDeHoy]);
    }
    
}
