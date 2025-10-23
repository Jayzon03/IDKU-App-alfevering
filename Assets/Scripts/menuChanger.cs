using UnityEngine;

public class menuScript: MonoBehaviour
{
    public GameObject foodPanel;
    public GameObject videoPanel;
    public GameObject mathPanel;
    
    void start ()
    {
        //Starts the app with FoodPanel as the only active Panel
        foodPanel.SetActive(true);
        videoPanel.SetActive(false);
        mathPanel.SetActive(false);
    }
    // Sets the active panel based on string input corresponding to the panel name 
    public void changeThat(string nameOfPanel)
    {
        videoPanel.SetActive(nameOfPanel == "Video");
        foodPanel.SetActive(nameOfPanel == "Food");
        mathPanel.SetActive(nameOfPanel == "Math");
    }
}
