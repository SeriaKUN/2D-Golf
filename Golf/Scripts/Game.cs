﻿using Golf.States;
using SFML.Graphics;
using SFML.Window;

namespace Golf
{
    class Game
    {
        static public bool endedPlaying = false;
        static private State currentState;
        static public RenderWindow window;

        public void Start()
        {
            currentState = new Starting();
            while (!endedPlaying)
            {
                Update();
                Render();
                Timing();
                Input();
            }
        }

        public static void SetState(State state)
        {
            currentState = state;
        }

        private void Input()
        {
            currentState.Input();
        }

        private void Update()
        {
            currentState.Update();
        }

        private void Render()
        {
            currentState.Render();
        }

        private void Timing()
        {
            Thread.Sleep(16);
        }
    }
}
