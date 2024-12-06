using UnityEngine;
using TMPro;

public class TextSwitcher : MonoBehaviour
{
    public TextMeshProUGUI main_text;
    public string[] texts;             // Array com os textos
    private int currentIndex = 0;

    private void Start()
    {
        UpdateText();
    }

    void UpdateText()
    {
        if (texts.Length > 0)
        {
            main_text.text = texts[currentIndex];
        }
    }

    public void NextText()
    {
        currentIndex += 1;
        UpdateText();
       
    }

    public void PreviousText()
    {
        currentIndex -= 1;
        UpdateText();
    }
}
