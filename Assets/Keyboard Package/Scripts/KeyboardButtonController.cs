using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeyboardButtonController : MonoBehaviour
{
    [SerializeField] Image containerBorderImage;
    [SerializeField] Image containerFillImage;
    [SerializeField] Image containerIcon;
    [SerializeField] TextMeshProUGUI containerText;
    [SerializeField] TextMeshProUGUI containerActionText;
    public AlphabetType alphabetType;

    private void Start() {
        SetContainerBorderColor(ColorDataStore.GetKeyboardBorderColor());
        SetContainerFillColor(ColorDataStore.GetKeyboardFillColor());
        SetContainerTextColor(ColorDataStore.GetKeyboardTextColor());
        SetContainerActionTextColor(ColorDataStore.GetKeyboardActionTextColor());
    }

    public void SetContainerBorderColor(Color color) => containerBorderImage.color = color;
    public void SetContainerFillColor(Color color) => containerFillImage.color = color;
    public void SetContainerTextColor(Color color) => containerText.color = color;
    public void SetContainerActionTextColor(Color color) { 
        containerActionText.color = color;
        containerIcon.color = color;
    }

    public void AddLetter() {
        if(GameManager.Instance != null) {
            GameManager.Instance.AddLetter(containerText.text);
        } else {
            Debug.Log(containerText.text + " is pressed");
            GameController.Ins.alphabetTypes.Add(alphabetType);
            //Check if list
            GameController.Ins.SpawnLetter();
        }
    }

    public void DeleteLetter() { 
        if(GameManager.Instance != null) {
            GameManager.Instance.DeleteLetter();
        } else {
            Debug.Log("Last char deleted");
            if(GameController.Ins.alphabetTypes.Count > 0)
                GameController.Ins.alphabetTypes.RemoveAt(GameController.Ins.alphabetTypes.Count - 1);
        }
    }
    public void SubmitWord() {
        if(GameManager.Instance != null) {
            GameManager.Instance.SubmitWord();
        } else {
            Debug.Log("Submitted successfully!");
        }
    }
}