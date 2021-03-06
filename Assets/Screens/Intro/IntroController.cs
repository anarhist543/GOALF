﻿
using UnityEngine;

public class IntroController : ScreenController {


    //Этот экран просто показывает лого и сразу переходит к меню
    private float currentTime;
    public float time;
    private bool active;

    public override void Init()
    {
        base.Init();
        active = true;
    }

    void Update()
    {
        if(active)
        {
            currentTime += Time.deltaTime;
            if(currentTime>=time)
            {
                active = false;
                MainController.controller.GoToScreen(MainController.controller.controllers[1], 0.5f, 0.5f, Color.white);
            }
        }
    }


}
