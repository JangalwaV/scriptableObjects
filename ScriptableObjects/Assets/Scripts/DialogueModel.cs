using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script is the actual Scriptable Object
[CreateAssetMenu(fileName = "NewDialogueModel", menuName = "Dialogue/Conversation")]
public class DialogueModel : ScriptableObject //use :ScriptableObject to define this class as a Scriptable Object
{
    //these are all different data points for the dialogue box
    [SerializeField] string _dialogue = "...";
    public string Dialogue
    {
        get { return _dialogue; }
        private set { _dialogue = value; }
    }

    public string CharacterName = "...";
    public Sprite CharacterPortrait = null;
}
