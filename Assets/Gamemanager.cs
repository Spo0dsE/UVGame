using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Gamemanager : MonoBehaviour
{
    [Header("Windows")]
    public GameObject Window;
    public GameObject tutorialwindow;

    [Header("mensen")]
    public GameObject persoon1;
    public GameObject persoon2;
    public GameObject persoon3;
    public GameObject persoon4;
    public GameObject persoon5;
  
    [Header("Programma")]
    public GameObject foto;
    public TMP_Text beschrijving;
    public UnityEngine.UI.Button JaKnop;
    public UnityEngine.UI.Button NeeKnop;

    [Header("beschrijving")]
    public string[] beschrijvingen;
    private int index;
    public float typespeed;

    private int Welkpersoonzijnweop;
    private bool tutorialread;

  

    public void Programeclick()
    {
        
        Window.SetActive(true);
        // dit zet het programa aan

        if (Welkpersoonzijnweop == 0)
        {
            persoon1.SetActive(true);
        }
        if (tutorialread == false)
        {
            tutorialwindow.SetActive(true);
        }
        // dit zet de tutoriaal aan
    }

    public void ExitclickWindow()
    {
       Window.SetActive(false);
        // dit zet het programa uit
    }

    public void ExitclickTuT()
    {
        tutorialread = true;
        //dit zorgt ervoor dat de tutoriaal niet terug komy
        tutorialwindow.SetActive(false);
        // dit zet de tutoriaal uit
    }

    private void Start()
    {
        beschrijving.text = string.Empty;
    }
    private void StartDialouge()
    {
        index = 0;
        StartCoroutine(Typeline());
    }

    void nextline()
    {
        if(index <  beschrijving.text.Length - 1)
        {
            index++;
            beschrijving.text = string.Empty;
            StartCoroutine (Typeline());

        }
    }
   public void Jaknop()
    {
        if (beschrijving.text == beschrijvingen[index])
        {

            nextline();
            StartDialouge();

        }
        Welkpersoonzijnweop += 1;

    }
    public void Neeknop()
    {
        if (beschrijving.text == beschrijvingen[index])
        {
            nextline();
        }
        Welkpersoonzijnweop += 1;
    }
    IEnumerator Typeline()
    {
        foreach (char c in beschrijvingen[index].ToCharArray())
        {
            beschrijving.text += c;
            yield return new WaitForSeconds(typespeed);
        }

    }
    public void Update()
    {
        if (Window == isActiveAndEnabled)
        {
            if (Welkpersoonzijnweop == 0)
            {
               
                persoon1.SetActive(true);
                persoon2.SetActive(false);
                persoon3.SetActive(false);
                persoon4.SetActive(false);
                persoon5.SetActive(false);

            }
            if (Welkpersoonzijnweop == 1)
            {
                persoon2.SetActive(true);
                persoon1.SetActive(false);
                persoon3.SetActive(false);
                persoon4.SetActive(false);
                persoon5.SetActive(false);
            }
            if (Welkpersoonzijnweop == 2)
            {
                persoon3.SetActive(true);
                persoon2.SetActive(false);
                persoon1.SetActive(false);
                persoon4.SetActive(false);
                persoon5.SetActive(false);
            }
            if (Welkpersoonzijnweop == 3)
            {
                persoon4.SetActive(true);
                persoon2.SetActive(false);
                persoon3.SetActive(false);
                persoon1.SetActive(false);
                persoon5.SetActive(false);
            }
            if (Welkpersoonzijnweop == 4)
            {
                persoon5.SetActive(true);
                persoon2.SetActive(false);
                persoon3.SetActive(false);
                persoon4.SetActive(false);
                persoon1.SetActive(false);
            }
            // dit zet alle fotos uit en aan
        }

        // als je meer mensen wilt toevoegen zet dan public GameObject persoon#
        // dupliceer een persoon object en sleep het gameobject naar de lege plek in de inspector
        // kopieer dit in de public void update
        //  if (Welkpersoonzijnweop == 5)
        //      {
        //  persoon5.SetActive(true);
        //         persoon2.SetActive(false);
        //         persoon3.SetActive(false);
        //         persoon4.SetActive(false);
        //         persoon1.SetActive(false);
        //     }
        // en vervang persoon5.SetActive(true) met persoon6.SetActive(true)
        // voeg toe persoon5.SetActive(false) 
        // aan alle andere blokjes van set active voeg persoon6.SetActive(false) too


    }
}
