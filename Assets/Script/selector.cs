using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class selector : MonoBehaviour
{
    // This is Dropdown component of Dropdown for selecting
    public Dropdown dropdown;

    // These are Button components of Start Button
    public GameObject startButtonObject;
    private Button startButton;
    private Image startButtonImage;

    // a List of Dropdown options
    private List<string> modeselect = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        // Get components of start button
        startButton = startButtonObject.GetComponent<Button>();
        startButtonImage = startButtonObject.GetComponent<Image>();

        // Set Dropdown options
        SetDropdownOptions();
    }

    // Set Dropdown options
    private void SetDropdownOptions()
    {
        // Clear the old options of the Dropdown menu
        dropdown.ClearOptions();

        // TO DO Something
        // Add values to your list

        // Add list of building name to dropdown options
        dropdown.AddOptions(modeselect);
    }

    // This method is attached to dropdown
    public void SetStartButton()
    {
        // This is the index number of the current selection in the Dropdown
        int index = dropdown.value;

        if (index == 0)
        {
            SceneManager.LoadScene("1_match");
        }
        if (index == 1)
        {
            SceneManager.LoadScene("2_course");
        }
        if (index == 2)
        {
            SceneManager.LoadScene("3_tutorial");
        }
    }
    
    private void OnStartSystem()
    {
            // TO DO Something
    }
}

public class btnmanager
{
    index = 0;
    
}