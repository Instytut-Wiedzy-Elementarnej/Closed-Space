using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronGameManager : MonoBehaviour
{
    private static IronGameManager instance;

    void Awake()
    {
        if (instance == null)
        {
            // Ustawienie obiektu GameManager jako obiektu niezniszczalnego
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Zapobieganie duplikowaniu obiektu GameManager
            Destroy(gameObject);
        }
    }
}