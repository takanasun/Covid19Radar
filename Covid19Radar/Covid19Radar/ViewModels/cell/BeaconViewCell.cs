﻿using System;
using Reactive.Bindings;
using Xamarin.Forms;

namespace Covid19Radar.Views.cell
{
    public class BeaconViewCell
    {
        public ReactiveProperty<String> UserUuid { get; set; } = new ReactiveProperty<String>();
    }
}