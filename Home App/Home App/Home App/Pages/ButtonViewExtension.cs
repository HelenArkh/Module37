﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;
using Xamarin.Forms.Xaml;

namespace Home_App.Pages
{
    public class ButtonViewExtension : IMarkupExtension
    {
        public ButtonStyle ButtonStyle { get; set; }

        /// <summary>
        /// Меняем числовое значение параметра в зависимости от переданной настройки
        /// </summary>
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            switch (ButtonStyle)
            {
                case ButtonStyle.Default:
                    return 0;
                case ButtonStyle.SemiRound:
                    return 15;
                case ButtonStyle.Round:
                    return 30;
                default:
                    return 0;
            }
        }       
    }
    /// <summary>
    /// Стили кнопок
    /// </summary>
    public enum ButtonStyle
    {
        Default,
        SemiRound,
        Round
    }
}
