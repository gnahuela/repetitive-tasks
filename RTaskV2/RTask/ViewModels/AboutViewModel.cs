using RTask.Common.IoC;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace RTask.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel(ITaskRepository taskRepository)
        {
            Title = "About";
            //OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            OpenWebCommand = new Command(() => { Title = taskRepository.GetTaskDefinition(1).Name; });
        }

        public ICommand OpenWebCommand { get; }
    }
}