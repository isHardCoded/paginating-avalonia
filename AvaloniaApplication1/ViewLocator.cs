using Avalonia.Controls;
using Avalonia.Controls.Templates;
using AvaloniaApplication1.ViewModels;
using System;
using System.Diagnostics.CodeAnalysis;

namespace AvaloniaApplication1
{
    /// <summary>
    /// Given a view model, returns the corresponding view if possible.
    /// </summary>
    [RequiresUnreferencedCode(
        "Default implementation of ViewLocator involves reflection which may be trimmed away.",
        Url = "https://docs.avaloniaui.net/docs/concepts/view-locator")]
    public class ViewLocator : IDataTemplate
    {
        public Control? Build(object? param)
        {

            if (param is null)
                return null;

            var name = param.GetType().FullName!.Replace("ViewModel", "View", StringComparison.Ordinal);
            var type = Type.GetType(name);

            if (type != null)
            {
                return (Control)Activator.CreateInstance(type)!;
            }

            return param switch
            {
                Page1ViewModel => new Page1View(),
                Page2ViewModel => new Page2View(),
                Page3ViewModel => new Page3View(),
                _ => null
            };
        }

        public bool Match(object? data)
        {
            return data is ViewModelBase;
        }
    }
}
