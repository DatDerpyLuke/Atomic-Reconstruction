using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public double quarks;
    public TMP_Text Qtext;

    public double electrons;
    public TMP_Text Etext;

    public double pn;
    public TMP_Text PNtext;

    public double hydrogen;
    public TMP_Text Hydrogentext;

    public double helium;
    public TMP_Text Heliumtext;

    public double carbon;
    public TMP_Text Carbontext;

    public double quarkMultiplier = 1;
    public double elecMultiplier = 1;
    public double pnMultiplier = 1;
    public double hydrogenMultiplier = 1;
    public double heliumMultiplier = 1;

    public GameObject Clicky;
    public GameObject SHeavy;

    private void Update()
    {
        Qtext.text = $"{quarks} quarks\n{quarkMultiplier}x";
        Etext.text = $"{electrons} electrons\n{elecMultiplier}x";
        PNtext.text = $"{pn} protons/neutrons\n{pnMultiplier}x";
        Hydrogentext.text = $"{hydrogen} hydrogen atoms\n{hydrogenMultiplier}x";
        Heliumtext.text = $"{helium} helium atoms\n{heliumMultiplier}x";
        Carbontext.text = $"{carbon} carbon atoms";
    }

    public void Qclick()
    {
        quarks += 1 * quarkMultiplier;
    }

    public void Eclick()
    {
        electrons += 1 * elecMultiplier;
    }

    public void PNmake()
    {
        if (quarks >= 3)
        {
            pn += 1 * pnMultiplier;
            quarks -= 3;
            quarkMultiplier += 0.5;
        }
    }

    public void Hmake()
    {
        if (pn >= 1 && electrons >= 1)
        {
            hydrogen += 1 * hydrogenMultiplier;
            pn -= 1;
            electrons -= 1;
            elecMultiplier += 0.5;
            pnMultiplier += 0.5;
        }
    }

    public void Hemake()
    {
        if (hydrogen >= 4)
        {
            helium += 1 * heliumMultiplier;
            hydrogen -= 4;
            hydrogenMultiplier += 0.5;
        }
    }

    public void Cmake()
    {
        if (helium >= 3)
        {
            carbon += 1;
            helium -= 3;
            heliumMultiplier += 0.75;
        }
    }

    public void ChangeMenus(int switcher)
    {
        switch (switcher)
        {
            case 1:
                Clicky.SetActive(true);
                SHeavy.SetActive(false);
                break;
            case 2:
                Clicky.SetActive(false);
                SHeavy.SetActive(true);
                break;
            case 99:
                Debug.Log("Hi, how are you?");
                break;
            default:
                break;
        }
    }
}
