using Microsoft.VisualStudio.Shell;
using System.ComponentModel;

public class GeneralOptions : DialogPage
{
    private string gistUrl = "";

    [Category("General")]
    [DisplayName("Gist URL")]
    [Description("Public GitHub Gist URL containing copilot-instructions.md")]
    public string GistUrl
    {
        get => gistUrl;
        set => gistUrl = value;
    }
}