using UnityEngine;

public class Vida : MonoBehaviour
{
    const int VALOR_INICIAL_VIDA = 3;

    int vida = VALOR_INICIAL_VIDA;

    public int VidaJugador
    {
        get
        {
            return vida;
        }
        set
        {
            if (value <= 0)
            {
                gameObject.SetActive(false);
               
            }
            else
            {

                vida = value;

            }
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("C##"))
        {

            collision.GetComponent<matiasenemigo>().InitDamage(this);
            

        }
    }
}
