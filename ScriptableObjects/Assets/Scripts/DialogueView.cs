using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//This script takes in data from DialogueModel and prepares it for DialogueController to run
public class DialogueView : MonoBehaviour
{
    [SerializeField] Text _nameTextUI = null;
    [SerializeField] Text _bodyTextUI = null;
    [SerializeField] Image _characterPortraitUI = null;

    public void Show()
    {
        gameObject.SetActive(true);
        //TODO play animations
    }

    public void Hide()
    {
        //TODO play animations
        gameObject.SetActive(false);
    }

    public void Display(DialogueModel data)
    {
        _nameTextUI.text = data.CharacterName;
        _bodyTextUI.text = data.Dialogue;
        _characterPortraitUI.sprite = data.CharacterPortrait;
    }

    public void Clear()
    {
        _nameTextUI.text = "";
        _bodyTextUI.text = "";
        _characterPortraitUI.sprite = null;
    }
}
