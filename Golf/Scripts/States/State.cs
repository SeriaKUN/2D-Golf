﻿
namespace Golf.States
{
    abstract class State
    {
        public abstract void Update();
        public abstract void Render();
        public abstract void Input();
    }
}
