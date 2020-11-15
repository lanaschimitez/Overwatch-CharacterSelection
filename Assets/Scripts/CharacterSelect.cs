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
    public GameObject glow;
    public GameObject borda;
    public Sprite imagem;

    void Start()
    {
        button = GetComponent<Button>();
        MoveUI = image.GetComponent<MoveUI>();
        glow = this.gameObject.transform.GetChild(3).gameObject;
        borda = GameObject.Find("Borda");
        glow.SetActive(false);
        MoveUI.Disable();
    }
    //Do this when the selectable UI object is selected.
    public void OnSelect(BaseEventData eventData)
    {
        glow.SetActive(true);
        this.gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        borda.gameObject.GetComponent<Image>().sprite = imagem;
        MoveUI.Enable();
    }
    public void OnDeselect(BaseEventData Data)
    {
        glow.SetActive(false);
        this.gameObject.transform.localScale = new Vector3(1f, 1f, 1.2f);
        MoveUI.Disable();
    }
}
