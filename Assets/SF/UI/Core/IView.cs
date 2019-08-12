using System;
using UnityEngine;

namespace SF.UI.Core
{
    public interface IView<out T> where T : ViewModelBase
    {
        T BindingContext { get; }
        void Create(bool immediate=false,Action<Transform> action=null);
        void Close(bool immediate=false,Action<Transform> action=null);
    }
}