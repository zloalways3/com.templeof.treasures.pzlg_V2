using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TempleA : MonoBehaviour
{
    private int zTemple;
    private int aaTemple;
    private float abTemple;
    private int adTemple;
    private int aeTemple;
    private int afTemple;
    private int agTemple;
    private int ahTemple;
    [SerializeField] private GameObject aTemple;
    [SerializeField] private GameObject bTemple;
    [SerializeField] private GameObject cTemple;
    [SerializeField] private GameObject dTemple;
    [SerializeField] private GameObject eTemple;
    [SerializeField] private GameObject fTemple;
    [SerializeField] private TempleB gTemple;
    [SerializeField] private TextMeshProUGUI hTemple;
    [SerializeField] private TextMeshProUGUI iTemple;
    [SerializeField] private TempleTi jTemple;
    [SerializeField] private Slider lTemple;
    [SerializeField] private AudioSource mTemple;
    [SerializeField] private AudioSource nTemple;
    [SerializeField] private AudioClip oTemple;
    [SerializeField] private AudioClip pTemple;
    [SerializeField] private AudioClip qTemple;
    [SerializeField] private TextMeshProUGUI rTemple;
    [SerializeField] private TextMeshProUGUI sTemple;
    [SerializeField] private GameObject tTemple;
    [SerializeField] private TextMeshProUGUI uTemple;
    [SerializeField] private TextMeshProUGUI uTemple1;
    [SerializeField] private TextMeshProUGUI vTemple;
    [SerializeField] private TextMeshProUGUI wTemple;
    [SerializeField] private TextMeshProUGUI xTemple1;
    [SerializeField] private TextMeshProUGUI yTemple;

    [SerializeField] private GameObject[] soundPoint;
    private float maxSound = 5;
    private float currentMaxSound;

    private bool kTempleFlag;

    private void RefreshSound()
    {
        for (int i111 = 0; i111 < soundPoint.Length; i111++)
        {
            if (i111 < (currentMaxSound + 1))
            {
                soundPoint[i111].SetActive(true);
            }
            else
            {
                soundPoint[i111].SetActive(false);
            }
        }
    }

    public void PlusSound()
    {
        BTemple();
        if (currentMaxSound < maxSound - 1)
        {
            currentMaxSound++;
            mTemple.volume = (currentMaxSound + 1) / maxSound;
            RefreshSound();
            PlayerPrefs.SetFloat("sou", currentMaxSound);
            PlayerPrefs.Save();
        }
    }

    public void MinusSound()
    {
        BTemple();
        if (currentMaxSound > -1)
        {
            currentMaxSound--;
            mTemple.volume = (currentMaxSound + 1) / maxSound;
            RefreshSound();
            PlayerPrefs.SetFloat("sou", currentMaxSound);
            PlayerPrefs.Save();
        }
    }

    private void BTemple()
    {
        Asdsd();
        mTemple.PlayOneShot(oTemple, 1f);
    }

    public void JTemple()
    {
        Asdsd();
        mTemple.PlayOneShot(pTemple, 1f);
    }

    public static void Asdsd()
    {
        var yy = 0;
        for (int p7 = 0; p7 < 33; p7++)
        {
            yy++;
        }
    }

    public void KTemple()
    {
        Asdsd();
        BTemple();
        aTemple.SetActive(false);
        cTemple.SetActive(true);
    }

    public void DTemple()
    {
        Asdsd();
        abTemple = lTemple.value;
        nTemple.volume = abTemple;
    }

    public void HTemple()
    {
        Asdsd();
        BTemple();
        bTemple.SetActive(false);
        jTemple.TempleJ();
        eTemple.SetActive(false);
        aTemple.SetActive(true);
        gTemple.gameObject.SetActive(true);
    }

    public void FTemple()
    {
        Asdsd();
        bTemple.SetActive(false);
        eTemple.SetActive(true);
        jTemple.TempleJ();
        if (jTemple.eTemple || aaTemple <= 0)
        {
            rTemple.text = "LOSE!!";
            sTemple.text = "LOSER!";
            uTemple.text = $"{zTemple}";
            tTemple.gameObject.SetActive(false);
        }
        else
        {
            rTemple.text = "YOU WIN!!";
            sTemple.text = "WINNER!!!";
            uTemple.text = $"{zTemple}";
            tTemple.gameObject.SetActive(true);
        }
    }

    public void TestTestAAAF()
    {
        Debug.Log("TESTAAAA");
    }

    public void ITemple()
    {
        Asdsd();
        BTemple();
        Application.Quit();
    }

    public void ETemple(int xTemple, int idTemple)
    {
        Asdsd();
        if (jTemple.TempleL())
        {
            zTemple = 30 * xTemple;
            hTemple.text = $"{zTemple}";

            if (idTemple == 0)
            {
                adTemple++;
                uTemple1.text = $"{adTemple}/2";
            }
            if (idTemple == 1)
            {
                aeTemple++;
                vTemple.text = $"{aeTemple}/2";
            }
            if (idTemple == 2)
            {
                afTemple++;
                wTemple.text = $"{afTemple}/2";
            }
            if (idTemple == 3)
            {
                agTemple++;
                xTemple1.text = $"{agTemple}/2";
            }

            if (idTemple == 4)
            {
                ahTemple++;
                yTemple.text = $"{ahTemple}/2";
            }

            if (adTemple >= 2 && aeTemple >= 2
                && afTemple >= 2 && agTemple >= 2 && ahTemple >= 2)
            {
                jTemple.TempleJ();
                FTemple();
            }

            aaTemple--;
            iTemple.text = $"MOVES: {aaTemple}";

            if (aaTemple == 0)
            {
                FTemple();
            }
        }
    }

    private void Start()
    {
        Application.targetFrameRate = 60;
        fTemple.SetActive(true);
        aTemple.SetActive(false);
        bTemple.SetActive(false);
        cTemple.SetActive(false);
        eTemple.SetActive(false);
        dTemple.SetActive(false);

        currentMaxSound = PlayerPrefs.GetFloat("sou", 4);
        RefreshSound();
        mTemple.volume = (currentMaxSound + 1) / maxSound;
        abTemple = PlayerPrefs.GetFloat("music", 1);
        lTemple.value = abTemple;
        nTemple.volume = abTemple;

        nTemple.clip = qTemple;
        nTemple.Play();
    }

    public void KTempleGame()
    {
        BTemple();
        bTemple.SetActive(false);
        cTemple.SetActive(true);

        jTemple.TempleJ();
        kTempleFlag = true;
    }

    public void LTemple()
    {
        BTemple();
        cTemple.SetActive(false);
        if (kTempleFlag)
        {
            kTempleFlag = false;
            bTemple.SetActive(true);
            jTemple.TempleK();
        }
        else
        {
            aTemple.SetActive(true);
        }

        PlayerPrefs.SetFloat("music", abTemple);
        PlayerPrefs.Save();
    }

    public void MTemple()
    {
        Asdsd();
        BTemple();
        aTemple.SetActive(false);
        dTemple.SetActive(true);
    }

    public void NTemple()
    {
        Asdsd();
        BTemple();
        dTemple.SetActive(false);
        aTemple.SetActive(true);
    }

    public void ATemple()
    {
        Asdsd();
        BTemple();
        fTemple.SetActive(false);
        aTemple.SetActive(true);
    }

    public void GTemple()
    {
        Asdsd();
        BTemple();
        adTemple = 0;
        aeTemple = 0;
        afTemple = 0;
        agTemple = 0;
        ahTemple = 0;
        uTemple1.text = $"{adTemple}/2";
        vTemple.text = $"{aeTemple}/2";
        wTemple.text = $"{afTemple}/2";
        xTemple1.text = $"{agTemple}/2";
        yTemple.text = $"{ahTemple}/2";

        aaTemple = 40;
        iTemple.text = $"MOVES: {aaTemple}";

        aTemple.SetActive(false);
        zTemple = 0;
        hTemple.text = $"{zTemple}";
        jTemple.gameObject.SetActive(true);
        jTemple.TempleI();
        gTemple.gameObject.SetActive(true);
        bTemple.SetActive(true);
        gTemple.TempleUb();
    }

    public void OTemple()
    {
        Asdsd();
        BTemple();
        eTemple.SetActive(false);
        aTemple.SetActive(true);
    }
}