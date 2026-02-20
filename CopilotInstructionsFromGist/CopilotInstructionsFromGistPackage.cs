using Microsoft.VisualStudio.Shell;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using Task = System.Threading.Tasks.Task;

namespace CopilotInstructionsFromGist
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [ProvideOptionPage(typeof(GeneralOptions), "Copilot Gist Sync", "General", 0, 0, true)]
    [Guid(CopilotInstructionsFromGistPackage.PackageGuidString)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    public sealed class CopilotInstructionsFromGistPackage : AsyncPackage
    {
        public const string PackageGuidString = "43f82a5f-e06b-4869-bee9-d5407b126afa";

        protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            await this.JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);
            await SyncCommand.InitializeAsync(this);
        }
    }
}