using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class boton : MonoBehaviour
{
    [SerializeField] Button[] botones;
    [SerializeField] public int[] secuencia = { 0,0,0,0,0,0};
    [SerializeField] public int indiceActual = 0;
    [SerializeField] public bool puedeJugar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Empezar());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Empezar()
    {
        puedeJugar = false;
        yield return new WaitForSeconds(0.5f);
        for (int i = 0; i < botones.Length; i++)
        {
            botones[i].interactable = false;
        }
        int aleatorio = (int)Random.Range(0, botones.Length);
        secuencia[indiceActual] = aleatorio;
        for (int i = 0; i <= indiceActual; i++)
        {
            if (indiceActual == i)
            {
                botones[secuencia[i]].interactable = (true);
                yield return new WaitForSeconds(1);
                botones[secuencia[i]].interactable = (false);
            }
            else
            {
                botones[secuencia[i]].interactable = (true);
                yield return new WaitForSeconds(1);
                botones[secuencia[i]].interactable = (false);
                yield return new WaitForSeconds(1);
            }
        }
        for (int i = 0; i < botones.Length; i++)
        {
            botones[i].interactable = true;
        }
        indiceActual++;
        puedeJugar = true;
    }
}
