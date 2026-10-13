using JetBrains.Annotations;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private int[] SecuenciaJugador;
    [SerializeField] int IndiceActualJugador;
    [SerializeField] boton Juego;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void ComprobarSecuencia(int numeroboton)
    {
        if (Juego.puedeJugar == false) return;
        SecuenciaJugador[IndiceActualJugador] = numeroboton;
        if (SecuenciaJugador[IndiceActualJugador] != Juego.secuencia[IndiceActualJugador])
        {
            Debug.Log("Perder");
            perder();
        }
        ++IndiceActualJugador;
        if(IndiceActualJugador == Juego.indiceActual)
        {
            IndiceActualJugador = 0;
            StartCoroutine(Juego.Empezar());
            if(IndiceActualJugador == SecuenciaJugador.Length)
            {
                Debug.Log("He ganado");
            }
        }
       
    }
    public void perder()
    {
        IndiceActualJugador = 0;
        Juego.indiceActual = 0;
        for(int i = 0; i < SecuenciaJugador.Length; ++i)
        {
            SecuenciaJugador[i] = 0;
            Juego.secuencia[i] = 0;
        }
        StartCoroutine(Juego.Empezar());
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
