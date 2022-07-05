using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HiScore", menuName = "Tools/Hi-Score", order =0)]
public class PuntajeAlto : PuntajePersistente
{
    public int score = 0;
    public int hiScore = 0;

}
