﻿using System;
using System.Windows;
using System.Windows.Input;
using Microsoft.Xna.Framework;

namespace MonogameWpf2.Util
{
    public class GameMouseButtonEventArgs
    {
        private readonly MouseButtonEventArgs _args;
        private readonly Lazy<Vector2> _position;

        public GameMouseButtonEventArgs(MouseButtonEventArgs args, IInputElement inputElement)
        {
            _args = args;
            _position = new Lazy<Vector2>(() => GameControlHelper.GetPosition(_args, inputElement));
        }

        public Vector2 Position
        {
            get { return _position.Value; }
        }
    }
}