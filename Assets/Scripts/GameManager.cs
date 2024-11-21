using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    [SerializeField] InputActionReference IA_Ref;
    [SerializeField] GameObject MenuPanel;

    private void OnEnable()
    {
        IA_Ref.action.started += MenuToggle;
    }

    private void MenuToggle(InputAction.CallbackContext obj)
    {
        MenuPanel.SetActive(!MenuPanel.activeSelf);
    }

    private void OnDisable()
    {
        IA_Ref.action.started -= MenuToggle;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
            Quit();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
