using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace RTask
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<TaskModel> TasksSection1 { get; set; }
        public ObservableCollection<TaskModel> TasksSection2 { get; set; }
        public ObservableCollection<TaskModel> TasksSection3 { get; set; }
        public ObservableCollection<TaskModel> TasksSection4 { get; set; }

        public MainPage()
        {
            InitializeComponent();

            TasksSection1 = new ObservableCollection<TaskModel>
            {
                new TaskModel { Description = "Task 1" },
                new TaskModel { Description = "Task 2" }
            };

            // Repeat the same for other sections...

            BindingContext = this;
        }

        private void OnCompleteClicked(object sender, EventArgs e)
        {
            // Handle the "Complete" button click event here
            // For example, you can get the associated task and perform some action.
        }

        private void OnAddTaskClicked(object sender, EventArgs e)
        {
            // Handle the "Add Task" button click event here
            // For example, you can add a new task to the collection.
        }
    }
    public class TaskModel
    {
        public bool Completed { get; set; }
        public string Description { get; set; }
    }

}
