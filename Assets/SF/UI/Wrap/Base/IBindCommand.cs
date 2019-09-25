﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.Events;

namespace Assets.SF.UI.Wrap
{
    public interface IBindCommand<T>
    {
        UnityEvent<T> GetBindCommandFunc();
    }

    public interface IBindCommand
    {
        UnityEvent GetBindCommandFunc();
    }
}
