﻿namespace Jojatekok.MoneroGUI.Views.OptionsWindow
{
    public partial class PathsView
    {
        public PathsView()
        {
            InitializeComponent();

#if DEBUG
            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime) return;
#endif

            var softwareFilter = Properties.Resources.TextFilterExecutableFiles + "|" + Properties.Resources.TextFilterAllFiles;
            PathSelectorFileWalletData.Filter = Properties.Resources.TextFilterWalletFiles + "|" + Properties.Resources.TextFilterAllFiles;
            PathSelectorSoftwareDaemon.Filter = softwareFilter;
            PathSelectorSoftwareWallet.Filter = softwareFilter;
            PathSelectorSoftwareMiner.Filter = softwareFilter;

            // Load settings
            var pathSettings = SettingsManager.Paths;
            PathSelectorFileWalletData.SelectedPath = pathSettings.FileWalletData;
            PathSelectorDirectoryWalletBackups.SelectedPath = pathSettings.DirectoryWalletBackups;
            PathSelectorSoftwareDaemon.SelectedPath = pathSettings.SoftwareDaemon;
            PathSelectorSoftwareWallet.SelectedPath = pathSettings.SoftwareWallet;
            PathSelectorSoftwareMiner.SelectedPath = pathSettings.SoftwareMiner;
        }

        public void ApplySettings()
        {
            var pathSettings = SettingsManager.Paths;
            pathSettings.FileWalletData = PathSelectorFileWalletData.SelectedPath;
            pathSettings.DirectoryWalletBackups = PathSelectorDirectoryWalletBackups.SelectedPath;
            pathSettings.SoftwareDaemon = PathSelectorSoftwareDaemon.SelectedPath;
            pathSettings.SoftwareWallet = PathSelectorSoftwareWallet.SelectedPath;
            pathSettings.SoftwareMiner = PathSelectorSoftwareMiner.SelectedPath;
        }
    }
}