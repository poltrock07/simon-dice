using System;
using UnityEngine;

public class jugador : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PulsarBoton(int i)
    {
        gameManager.ComprobarSecuencia(i);
    }
}
