using System.Collections;
using JetBrains.Annotations;
using UnityEngine;


public class matiasenemigo : MonoBehaviour
{
    Transform matias;

    const int VALOR_INICIAL_VIDA = 3;

     int vida = VALOR_INICIAL_VIDA;

    Vida vidaJugador;

    public int VidaPropertie
    {
        get
        {
            return vida;
        }
        set
        {
            if(value <= 0)
            {
                gameObject.SetActive(false);
                vida = VALOR_INICIAL_VIDA;
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
        Perseguir();
        
    }
    public void Perseguir()
    {
        if(matias != null)
        {
          
          transform.position = Vector2.MoveTowards(transform.position, matias.position, 1 * Time.deltaTime);
 
        }
    }
    public void SetUp(Transform matiasPos)
    {
        matias = matiasPos;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Bullet"))
        {
            
            VidaPropertie--;
            
        }
    }
    public void Damage()
    {

        vidaJugador.VidaJugador--;
        StartCoroutine(InitDamaging());
    }
    public IEnumerator InitDamaging()
    {
        yield return new WaitForSeconds(1.5f);
        Damage();
    }
    public void InitDamage(Vida vidaJugador)
    {
        this.vidaJugador = vidaJugador;
        StartCoroutine(InitDamaging());

    }
}
