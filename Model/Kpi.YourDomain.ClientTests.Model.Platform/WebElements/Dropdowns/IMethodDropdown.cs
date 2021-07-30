﻿namespace Kpi.UkrNet.ClientTests.Model.Platform.WebElements.Dropdowns
{
    public interface IMethodDropdown
    {
        void OpenDropdown();

        void Select(string option);

        string[] GetOptions();
    }
}
