using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour
{
    public GameObject textBox;

    public Text theText;

    public TextAsset textFile;
    public string[] textLines;

    public int currentLine;
    public int endAtLine;

    public PlayerController player;

    void Start()
    {

        player = FindObjectOfType<PlayerController>();

        if (textFile != null)
        {
            textLines = (textFile.text.Split('\n'));
        }
        if (endAtLine == 0)
        {
            endAtLine = textLines.Length;
        }
    }
     void Update()
    {
        theText.text = textLines[currentLine];

        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentLine += 1;
        }
        if (currentLine > endAtLine)
        {
            DisableTextBox();
            currentLine = 0;
            Time.timeScale = 1;
        }

    }

    public void EnableTextBox()
    {
        textBox.SetActive(true);
    }
    public void DisableTextBox()
    {
        textBox.SetActive(false);
    }

    public void ReloadScript(TextAsset theText)
    {
        if (theText != null)
        {
            textLines = new string[1];
            textLines = (theText.text.Split('\n'));
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            textBox.SetActive(true);
            Time.timeScale = 0;

        }
    }
}
