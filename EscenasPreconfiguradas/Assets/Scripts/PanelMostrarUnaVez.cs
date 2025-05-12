using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelMostrarUnaVez : MonoBehaviour
{
    public GameObject panel; // Arrastra aquí tu panel en el Inspector
    public string PREF_KEY = "BienvenidaMostrada";

    void Start()
    {
        if (!PlayerPrefs.HasKey(PREF_KEY))
        {
            // Primera vez: mostrar el panel y guardar que se mostró
            panel.SetActive(true);
            PlayerPrefs.SetInt(PREF_KEY, 1);
            PlayerPrefs.Save();

            StartCoroutine(EsconderPanelDespuesDeSegundos(5f));
        }
        else
        {
            panel.SetActive(false);
            ActivateMoveForward();
        }
    }


    IEnumerator EsconderPanelDespuesDeSegundos(float segundos)
    {
        yield return new WaitForSeconds(segundos);
        panel.SetActive(false);
        ActivateMoveForward();
    }

    void ActivateMoveForward()
    {
        MoveForward mf = FindObjectOfType<MoveForward>();
        if (mf != null)
        {
            mf.move = true;
        }
    }
}
