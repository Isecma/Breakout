using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    public Transform transformHiScore;
    public Transform transformScore;
    public TMP_Text textHiScore;
    public TMP_Text textScore;
    public PuntajeAlto hiScoreSO;
    public Opciones opcionesSO;

    // Start is called before the first frame update
    void Start()
    {
        transformScore = GameObject.Find("Score").transform;
        transformHiScore = GameObject.Find("HiScore").transform;
        textScore = transformScore.GetComponent<TMP_Text>();
        textHiScore = transformHiScore.GetComponent<TMP_Text>();

        //if (PlayerPrefs.HasKey("HiScore"))
        //{
        //hiScore = PlayerPrefs.GetInt("HiScore");
        //}
        hiScoreSO.Cargar();
        textHiScore.text = $"Hi-Score: {hiScoreSO.hiScore}";
        hiScoreSO.score = 0;

    }
    //private void FixedUpdate()
    //{
    //    hiScoreSO.score += 5;
    //}

    // Update is called once per frame
    void Update()
    {
        textScore.text = $"Score: {hiScoreSO.score}";
        if (hiScoreSO.score > hiScoreSO.hiScore)
        {
            hiScoreSO.hiScore = hiScoreSO.score;
            textHiScore.text = $"Hi-Score: {hiScoreSO.hiScore}";
            hiScoreSO.Guardar();
            //PlayerPrefs.SetInt("HiScore", score);
        }
    }
    public void AumentarPuntaje(int puntos)
    {
        if (opcionesSO.NivelDificultad == Opciones.dificultad.easy)
        {
            hiScoreSO.score += puntos;
        }
        else if (opcionesSO.NivelDificultad == Opciones.dificultad.normal)
        {
            hiScoreSO.score += puntos * 2;
        }
        else if (opcionesSO.NivelDificultad == Opciones.dificultad.hard)
        {
            hiScoreSO.score += puntos * 3;
        }
    }
}
