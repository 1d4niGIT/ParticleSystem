using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public BaseAbility[] abilities;

    private InputSystem_Actions inputs;

    private BaseAbility current;

    private void Awake()
    {
        inputs = new();
    }

    private void OnEnable()
    {
        inputs.Enable();
        inputs.Player.Ability1.performed += SelectAbility1;
        inputs.Player.Ability2.performed += SelectAbility2;
        inputs.Player.Ability3.performed += SelectAbility3;
        inputs.Player.Ability4.performed += SelectAbility4;
        inputs.Player.Ability5.performed += SelectAbility5;

        inputs.Player.Attack.performed += OnCast;
    }

    private void OnCast(InputAction.CallbackContext context)
    {
        if (current == null) return;

        current.Execute();
        current = null;
    }

    #region Ability Selector
    private void SelectAbility1(InputAction.CallbackContext context)
    {
        Select(0);
    }

    private void SelectAbility2(InputAction.CallbackContext context)
    {
        Select(1);
    }

    private void SelectAbility3(InputAction.CallbackContext context)
    {
        Select(2);
    }

    private void SelectAbility4(InputAction.CallbackContext context)
    {
        Select(3);
    }

    private void SelectAbility5(InputAction.CallbackContext context)
    {
        Select(4);
    }

    #endregion

    private void OnDisable()
    {
        inputs.Disable();
    }

    public void Select(int index)
    {
        current = abilities[index];
    }



}
