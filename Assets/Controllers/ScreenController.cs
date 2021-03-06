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

    public virtual void Init(object[] args)
    {

    }

    /// <summary>
    /// Вызывается при сворачивании игры
    /// </summary>
    public virtual void GameNotFocus()
    {

    }

    /// <summary>
    /// Вызыватся при нажатии на кнопуку "Назад"
    /// </summary>
    public virtual void OnEscapeButtonPressed()
    {

    }

    /// <summary>
    /// Инициализация контроллера при начале игры
    /// </summary>
    public virtual void GameLoadInitialization()
    {

    }

    /// <summary>
    /// Вызывается при переходе к другому экрану непосредственно перед моментом перехода
    /// </summary>
    public virtual void Final()
    {

    }

}

