using UnityEngine;
using TMPro;

public class mathScript : MonoBehaviour
{

    public TextMeshProUGUI voresText;
    public int startingNumber = 10;
    private int currentNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentNumber = startingNumber;
        UpdateNumber();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MinusNumber(int numberToMinus)
    {
        currentNumber -= numberToMinus;
        UpdateNumber();
    }
    public void PlusNumber(int numberToPlus)
    {
        currentNumber += numberToPlus;
        UpdateNumber();
    }

    public void UpdateNumber()
    {
        voresText.text = currentNumber.ToString();
    }
}