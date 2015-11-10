﻿using Cirrious.CrossCore;
using MoneyManager.Core.ViewModels;

namespace MoneyManager.Windows.Dialogs
{
    public sealed partial class SelectDateRangeDialog
    {
        public SelectDateRangeDialog()
        {
            InitializeComponent();

            DataContext = Mvx.Resolve<SelectDateRangeDialogViewModel>();
        }
    }
}