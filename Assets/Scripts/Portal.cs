using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public string cenaAlvo;
    public Transform pontoRetorno;

    public bool deveAtivarRetorno;
    public int id;

    static bool deveRetornar;
    static int idRetorno;
    void Start() {
        
        if (deveRetornar && id == idRetorno) {
            GameObject jogadorGbj = GameObject.FindWithTag("Player");
            Transform jogadorTr = jogadorGbj.GetComponent<Transform>();
            jogadorTr.position = pontoRetorno.position;
            jogadorTr.rotation = pontoRetorno.rotation;
        }
    }

   
    void OnTriggerEnter(Collider col) {
        if (col.tag == "Player") {
    
            if (deveAtivarRetorno) {
                deveRetornar = true;
            }
            idRetorno = id;
           SceneManager.LoadScene(cenaAlvo);
        }
    }
}
    