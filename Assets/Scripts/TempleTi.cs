using TMPro;
using UnityEngine;

public class TempleTi : MonoBehaviour
{
    private float bTemple;
    private bool dTemple;
    public bool eTemple;

    [SerializeField] private float aTemple;
    [SerializeField] private TempleA cTemple;
    [SerializeField] private TextMeshProUGUI fTemple;

    public void TempleJ()
    {
        TempleA.Asdsd();
        dTemple = false;
    }

    public void TempleK()
    {
        TempleA.Asdsd();
        dTemple = true;
    }

    void Update()
    {
        if (dTemple)
        {
            if (bTemple > 0)
            {
                var ll = 0;
                bTemple -= Time.deltaTime;
            }
            else
            {
                bTemple = 0;
                dTemple = false;
                eTemple = true;
                cTemple.FTemple();
            }
            TempleM(bTemple);
        }
    }

    public void TempleG(int h)
    {
        TempleA.Asdsd();
        aTemple = h;
    }

    public void TempleI()
    {
        TempleA.Asdsd();
        bTemple = aTemple;
        dTemple = true;
        eTemple = false;
    }

    public bool TempleL()
    {
        TempleA.Asdsd();
        return dTemple;
    }

    private void TempleM(float nTemple)
    {
        TempleA.Asdsd();
        if (nTemple < 0)
        {
            nTemple = 0;
        }
        float oTemple = Mathf.FloorToInt(nTemple / 60);
        float pTemple = Mathf.FloorToInt(nTemple % 60);
        fTemple.text = $"TIMES: {string.Format(" {0:00}:{1:00}", oTemple, pTemple)}";
    }
}
