﻿using Finsculpt.Views;

namespace Finsculpt
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ManageExpensesPage), typeof(ManageExpensesPage));
        }
    }
}
