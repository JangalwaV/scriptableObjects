using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script parses inputs and runs DialogueView functions
public class DialogueController : MonoBehaviour
{
    [SerializeField] DialogueView _view = null;
    [Header("Dialogue")]
    [SerializeField] DialogueModel _dialogueOne = null;
    [SerializeField] DialogueModel _dialogueTwo = null;


    private void Start()
    {
        _view.Hide();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //show dia
            _view.Show();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //display dia 1
            _view.Display(_dialogueOne);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            //display dia 2
            _view.Display(_dialogueTwo);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            //hide dia
            _view.Hide();
        }
    }
}
