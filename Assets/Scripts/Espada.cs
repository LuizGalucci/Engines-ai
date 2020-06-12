using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espada : MonoBehaviour
{
    public float dano;

    void OnTriggerEnter(Collider col) {
        if (col.gameObject.CompareTag("Inimigo")) {
            Vida vidaInimigo = col.gameObject.GetComponent<Vida>();
            vidaInimigo.DiminuirVida(dano);
        }
    }
}