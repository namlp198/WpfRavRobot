using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace WpfRavRobot.Command
{
    public class BaseCommand : ICommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canExecute;

        public BaseCommand(Action<object> execute)
        {
            this._execute = execute;
            this._canExecute = null;
        }
        public BaseCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            this._execute = execute;
            this._canExecute = canExecute;
        }
        public bool CanExecute(object parameter)
        {
            return this._canExecute == null || this.CanExecute(parameter);
        }
        public void Execute(object parameter)
        {
            this._execute(parameter);
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
