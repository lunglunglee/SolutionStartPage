﻿namespace SolutionStartPage.Core.Views.BasicPart
{
    using Shared.Models;
    using Shared.Views.BasicPart;

    public class VsoPagePresenter : BasePresenter<IVsoPageView, IVsoPageViewModel>,
                                    IVsoPagePresenter
    {
        /////////////////////////////////////////////////////////
        #region Fields

        private readonly IVisualStudioVersion _vsVersion;
        private readonly IIde _ide;

        #endregion

        /////////////////////////////////////////////////////////
        #region Constructors

        public VsoPagePresenter(IVisualStudioVersion vsVersion, IIde ide, IVsoPageView view, IVsoPageViewModel viewModel)
            : base(view, viewModel)
        {
            _vsVersion = vsVersion;
            _ide = ide;

            LoadVmContent();

            View.ConnectDataSource(ViewModel);
        }

        #endregion

        /////////////////////////////////////////////////////////
        #region Private Methods
        
        private void LoadVmContent()
        {
            ViewModel.StartPageHeaderTitle = $"{_ide.Edition} {_vsVersion.LongVersion}";
        }

        #endregion
    }
}