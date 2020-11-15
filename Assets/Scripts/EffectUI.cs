using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectUI : MonoBehaviour
{
    public List<GameObject> objectsUI = new List<GameObject>();
    public float m_SmoothTime = 8.0f;
    public int count;
    public bool ativo;


    void Start()
    {
        ativo = false;
        foreach (Transform child in transform)
        {
            objectsUI.Add(child.gameObject);
        }
        InvokeRepeating("Fade", .1f, .2f);
    }

    void Fade()
    {
            objectsUI[count].SetActive(ativo);
            count ++;
            if (count > 6)
            {
                count = 0;
            ativo = !ativo;
            }
    }

}


