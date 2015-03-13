﻿using UnityEngine;
using System.Collections;


public class ManagerExample : MonoBehaviour 
{
    public GameObject panelMenu;
    public GameObject panelLocalization;
    public GameObject panelIni;

    public void GLocalization()
    {
        panelLocalization.SetActive(true);
        panelMenu.SetActive(false);
    }

    public void BLocalization()
    {
        panelLocalization.SetActive(false);
        panelMenu.SetActive(true);
    }

    public void GIni()
    {
        panelIni.SetActive(true);
        panelMenu.SetActive(false);
    }

    public void BIni()
    {
        panelIni.SetActive(false);
        panelMenu.SetActive(true);
    }
}