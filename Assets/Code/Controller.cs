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

    public double quarkMultiplier = 1;
    public double elecMultiplier = 1;
    public double pnMultiplier = 1;

    public GameObject Clicky;

    private void Update()
    {
        Qtext.text = $"{quarks} quarks";
        Etext.text = $"{electrons} electrons";
        PNtext.text = $"{pn} protons/neutrons";
        Hydrogentext.text = $"{hydrogen} hydrogen atoms";
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
            hydrogen += 1;
            pn -= 1;
            electrons -= 1;
            elecMultiplier += 0.5;
            pnMultiplier += 0.5;
        }
    }

    public void ChangeMenus(int switcher)
    {
        switch (switcher)
        {
            case 1:
                Clicky.SetActive(true);
                break;
            case 99:
                Debug.Log("Hi, how are you?");
                break;
            default:
                break;
        }
    }
}
