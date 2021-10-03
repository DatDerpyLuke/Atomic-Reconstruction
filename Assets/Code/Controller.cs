using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public int quarks;
    public TMP_Text Qtext;

    public int electrons;
    public TMP_Text Etext;

    public int pn;
    public TMP_Text PNtext;

    private void Update()
    {
        Qtext.text = $"{quarks} quarks";
        Etext.text = $"{electrons} electrons";
        PNtext.text = $"{pn} protons/neutrons";
    }

    public void Qclick()
    {
        quarks += 1;
    }

    public void Eclick()
    {
        electrons += 1;
    }

    public void PNmake()
    {
        if (quarks >= 3)
        {
            pn += 1;
            quarks -= 3;
        }
    }
}
