using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class CharacterSelect : MonoBehaviour, ISelectHandler, IDeselectHandler// required interface when using the OnSelect method.
{
    [Header("Informações")]
    public string m_nome;
    public Button button;
    public GameObject image;
    public MoveUI MoveUI;

    void Start()
    {
        button = GetComponent<Button>();
        MoveUI = image.GetComponent<MoveUI>();
        MoveUI.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Do this when the selectable UI object is selected.
    public void OnSelect(BaseEventData eventData)
    {
        Debug.Log(this.gameObject.name + " was selected");
        this.gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        MoveUI.Enable();
    }
    public void OnDeselect(BaseEventData Data)
    {
        Debug.Log("Deselected " + this.gameObject.name);
        this.gameObject.transform.localScale = new Vector3(1f, 1f, 1.2f);
        MoveUI.Disable();
    }
}
