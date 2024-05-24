using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    ScoreKeeper scoreKeeper;
    ASM_MN asm;

    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        asm = gameObject.AddComponent <ASM_MN>();
    }

    void Start()
    {
        scoreText.text = "You Scored:\n" + scoreKeeper.GetScore();

        asm.YC1();
        asm.YC2();
        
        //ASM_MN.YC3();
        //ASM_MN.YC4();
        //ASM_MN.YC5();
        //ASM_MN.YC6();
        //ASM_MN.YC7();
    }

    


}
