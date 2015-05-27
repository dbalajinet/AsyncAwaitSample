﻿using System;
using System.Windows.Input;

namespace AsyncAwaitSample
{
    class Command<T> : ICommand
    {
        private readonly Action<T> _action;

        public Command(Action<T> action)
        {
            _action = action;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _action((T) parameter);
        }
    }
}
