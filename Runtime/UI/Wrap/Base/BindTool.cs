﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Framework.UI.Core;
using TMPro;
using UnityEngine.UI;

namespace Framework.UI.Wrap.Base
{
    public static class BindTool
    {
        private static readonly Dictionary<Type, Type> supportWrapperTypes = new Dictionary<Type, Type>
        {
            {typeof(Text), typeof(TextWrapper)},
            {typeof(Toggle), typeof(ToggleWrapper)},
            {typeof(InputField), typeof(InputFieldWrapper)},
            {typeof(Slider), typeof(SliderWrapper)},
            {typeof(Button), typeof(ButtonWrapper)},
            {typeof(Image), typeof(ImageWrapper)},
            {typeof(Dropdown), typeof(DropdownWrapper)},
            {typeof(TextMeshProUGUI), typeof(TmpWrapper)},
            {typeof(TMP_InputField), typeof(TMPInputFieldWrapper)}
        };

        private static readonly object[] args = new object[2];

        public static object GetDefaultWrapper<T>(object container, T component)
        {
            foreach (var type in supportWrapperTypes)
                if (type.Key.IsInstanceOfType(component))
                {
                    args[1] = container;
                    args[0] = component;
                    return Activator.CreateInstance(type.Value, args);
                }
            return null;
        }
    }
}