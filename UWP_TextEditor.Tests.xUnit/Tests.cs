using System;

using UWP_TextEditor.ViewModels;

using Xunit;

namespace UWP_TextEditor.Tests.XUnit
{
    // TODO: Add appropriate tests
    public class Tests
    {
        [Fact]
        public void TestMethod1()
        {
        }

        // TODO: Add tests for functionality you add to InkDrawPictureViewModel.
        [Fact]
        public void TestInkDrawPictureViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new InkDrawPictureViewModel();
            Assert.NotNull(vm);
        }

        // TODO: Add tests for functionality you add to InkSmartCanvasViewModel.
        [Fact]
        public void TestInkSmartCanvasViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new InkSmartCanvasViewModel();
            Assert.NotNull(vm);
        }

        // TODO: Add tests for functionality you add to MainViewModel.
        [Fact]
        public void TestMainViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new MainViewModel();
            Assert.NotNull(vm);
        }

        // TODO: Add tests for functionality you add to SettingsViewModel.
        [Fact]
        public void TestSettingsViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new SettingsViewModel();
            Assert.NotNull(vm);
        }
    }
}
