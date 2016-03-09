/*  Author: Zackary Hoyt
    Scripts: GameMenu.cs
    Description: 
        Menu for the title screen.
        Options:
            Control Info
            Game/Control Settings (DISABLED)
            Main Menu
            Return to Game
*/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameMenu : MonoBehaviour
{
    [SerializeField]
    GameObject menu_Main, menu_Settings, menu_Controls, menu_Exit;

    Stack<int> menuIDStack = new Stack<int>();
    const int menuID_Open = 0, menuID_Main = 10, menuID_Settings = 20, menuID_Controls = 30, menuID_Exit = 40;

    MenuSounds menusounds;

    void Start()
    {
        menusounds = transform.parent.GetComponent<MenuSounds>();

    }

    void Update()
    {
        pollForMenuToggle();
    }

    void pollForMenuToggle()
    { 
        if (Input.GetKeyDown(KeyCode.Escape))
            if (menuIDStack.Count == 0)
            {
                menuIDStack.Push(menuID_Open);
                UpdateMenu();
            }
            else
                closeMenu();
    }

    void UpdateMenu()
    { 
        if (menuIDStack.Count > 0)
            switch (menuIDStack.Peek())
            {
                case menuID_Open:
                    openMenu();
                    break;
                case menuID_Main:
                    if (!menu_Main.activeSelf)
                        openMainMenu();
                    break;
                case menuID_Settings:
                    if (!menu_Settings.activeSelf)
                        openSettingsMenu();
                    break;
                case menuID_Controls:
                    if (!menu_Controls.activeSelf)
                        openControlsMenu();
                    break;
                case menuID_Exit:
                    if (!menu_Exit.activeSelf)
                        openExitMenu();
                    break;
                default:
                    if (menu_Main.activeSelf)
                        closeMenu();
                    break;
            }

    }
    public void deactivateAllMenus()
    {
        menu_Main.SetActive(false);
        menu_Settings.SetActive(false);
        menu_Controls.SetActive(false);
        menu_Exit.SetActive(false);
    }

    #region Menu Managers

    #region Game Menu Open/Close
    void openMenu()
    {
		GetComponent<GameEndScreen>().deactivateScreens();
        showCursor();
        PCSettings.staticRef.canControlPlayer = false;
        Time.timeScale = 0;

        menuIDStack.Clear();
        menuIDStack.Push(menuID_Main);
        UpdateMenu();
    }
    public void closeMenu()
    {
        hideCursor();
        PCSettings.staticRef.canControlPlayer = true;
        Time.timeScale = 1;
        
        menuIDStack.Clear();
        deactivateAllMenus();
    }

    public void showCursor() { Cursor.lockState = CursorLockMode.None; Cursor.visible = true; }
    public void hideCursor() { Cursor.lockState = CursorLockMode.Confined; Cursor.lockState = CursorLockMode.Locked; Cursor.visible = false; }
    #endregion

    #region Menus
    void openMainMenu()
    {
        deactivateAllMenus();
        menu_Main.SetActive(true);
    }
    void openSettingsMenu()
    {
        deactivateAllMenus();
        menu_Settings.SetActive(true);
    }
    void openControlsMenu()
    {
        deactivateAllMenus();
        menu_Controls.SetActive(true);
    }
    void openExitMenu()
    {
        deactivateAllMenus();
        menu_Exit.SetActive(true);
    }
    #endregion

    #region Menu Options
    public void openMenu_Main() { menusounds.PlayOneShot_Click(); menuIDStack.Push(menuID_Main); UpdateMenu(); }
    public void openMenu_Settings() { menusounds.PlayOneShot_Click(); menuIDStack.Push(menuID_Settings); UpdateMenu(); }
    public void openMenu_Controls() { menusounds.PlayOneShot_Click(); menuIDStack.Push(menuID_Controls); UpdateMenu(); }
    public void openMenu_Exit() { menusounds.PlayOneShot_Click(); menuIDStack.Push(menuID_Exit); UpdateMenu(); }
    public void back()
    {
        menusounds.PlayOneShot_Click();
        deactivateAllMenus();

        if (menuIDStack.Count > 0)
            menuIDStack.Pop();

        if (menuIDStack.Count == 0)
            closeMenu();
        UpdateMenu();
    }
    #endregion

    #region Game Returns
    public void returnToGame() { GetComponent<GameEndScreen>().deactivateScreens(); closeMenu(); }
    public void returnToTitle()
    {
        GetComponent<GameEndScreen>().deactivateScreens();
        closeMenu();
        GameObject.FindObjectOfType<PlayerController>().transform.position = PCSettings.staticRef.spawnpoint;
        FindObjectOfType<LevelLoader>().loadTitleScreen();
    }
    #endregion

    #endregion
}
