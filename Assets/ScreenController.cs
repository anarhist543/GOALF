﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Интерфейс для создания контроллеров
/// </summary>
public class ScreenController : MonoBehaviour
{

    public Camera cam;
    /// <summary>
    /// Инициализация контроллера при переходе к соответствующему экрану экрану
    /// </summary>
    public virtual void Init()
    {

    }

    /// <summary>
    /// Инициализация контроллера при начале игры
    /// </summary>
    public virtual void GameLoadInitialization()
    {

    }

    public virtual void Final()
    {

    }

}

